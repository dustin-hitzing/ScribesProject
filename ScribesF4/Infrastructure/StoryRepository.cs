using ScribesF4.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScribesF4.Infrastructure {
    public class StoryRepository {
        private ApplicationDbContext _db;
        public StoryRepository(DbContext db) {
            _db = (ApplicationDbContext)db;
        }
        public IQueryable<Story> FindStoriesByUser(string userName) {
            return from s in _db.Stories
                   from a in s.Authors
                   where a.UserName == userName
                   select s;
        }
    }
}