using ScribesF4.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;

namespace ScribesF4.Infrastructure {
    public class AnotherUserRepository {
        private ApplicationDbContext _db;
        public AnotherUserRepository(DbContext db) {
            _db = (ApplicationDbContext)db;
        }

        public void Add(ApplicationUser entity) {
            _db.Set<ApplicationUser>().Add(entity);
        }

        public void SaveChanges() {
            try {
                _db.SaveChanges();
            }
            catch (DbEntityValidationException dbError) {
                var firstError = dbError.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage;
                throw new ValidationException(firstError);
            }
        }
    }
}