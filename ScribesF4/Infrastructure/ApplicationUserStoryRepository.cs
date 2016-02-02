using ScribesF4.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScribesF4.Infrastructure {
    public class ApplicationUserStoryRepository: GenericRepository<ApplicationUserStory> {
        public ApplicationUserStoryRepository(DbContext db) : base(db) { }
    }

}