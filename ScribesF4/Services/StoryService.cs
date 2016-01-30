using Microsoft.AspNet.Identity;
using ScribesF4.Domain;
using ScribesF4.Infrastructure;
using ScribesF4.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Services {
    public class StoryService {
        private StoryRepository _storyRepo;
        private EntryRepository _entryRepo;
        private ApplicationUserManager _userRepo;
        public StoryService(StoryRepository storyRepo, EntryRepository entryRepo, ApplicationUserManager userRepo) {
            _storyRepo = storyRepo;
            _entryRepo = entryRepo;
            _userRepo = userRepo;
        }

        public StoryDTO GetCurrentStory(int storyId, string userName) {
            var userStories = _storyRepo.FindStoriesByUser(userName);
            return (from s in userStories
                    where s.Id == storyId
                    select new StoryDTO() {
                        Id = s.Id,
                        Entries = (from e in s.Entries
                                   select new EntryDTO() {
                                       Content = e.Content
                                   }).ToList()
                    }).FirstOrDefault();

        }

        public EntryDTO AddEntry(EntryDTO newEntry, string userName) {
            var currentStory = (from s in _storyRepo.FindStoriesByUser(userName)
                                where s.Id == newEntry.StoryId
                                select s).FirstOrDefault();
            var Submission = new Entry() {
                Content = newEntry.Content,
                Owner = _userRepo.FindByName(userName),
                Story = currentStory

            };

            _entryRepo.Add(Submission);
            _entryRepo.SaveChanges();
            return new EntryDTO() {
                Content = Submission.Content
            };
        }
    }
}

