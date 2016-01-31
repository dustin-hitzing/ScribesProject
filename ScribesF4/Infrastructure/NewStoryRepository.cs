using ScribesF4.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ScribesF4.Infrastructure {
    public class NewStoryRepository:GenericRepository<Story> {
        public NewStoryRepository(DbContext db) : base(db) { }

    }
}