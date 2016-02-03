using Microsoft.AspNet.Identity;
using ScribesF4.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Services {
    public class FriendsService {
        public ApplicationUserManager _userRepo;
        public FriendsService(ApplicationUserManager userRepo) {
            _userRepo = userRepo;
        }
        public IList<ApplicationUserDTO> FindUsers() {
            return (from u in _userRepo.Users
                    select new ApplicationUserDTO() {
                        Id = u.Id,
                        UserName = u.UserName
                    }).ToList();
        }

        //public IList<FriendDTO> ListFriends(string userName) {
        //    var user = _userRepo.FindByName(userName);
        //    return (from f in user.Friends
        //            select new FriendDTO() {
        //                Id = f.Id,
        //                Individual = new ApplicationUserDTO() {
        //                    UserName = f.Individual.UserName,
        //                    Id = f.Individual.Id
        //                }
        //            }).ToList();
        //}
        public IList<ApplicationUserDTO> ListUsers(string searchTerm) {
            return (from u in _userRepo.Users
                    where u.UserName.Contains(searchTerm) ||
                    u.UserName.StartsWith(searchTerm) 
                    select new ApplicationUserDTO() {
                        Id = u.Id,
                        UserName = u.UserName,

                    }).ToList();
        }
    }
}