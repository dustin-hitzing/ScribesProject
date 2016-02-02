using ScribesF4.Domain;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ScribesF4.Infrastructure {
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false) {
        }

        public static ApplicationDbContext Create() {
            return new ApplicationDbContext();
        }
        public IDbSet<Friend> Friends { get; set; }
        public IDbSet<ApplicationUserStory> UserStories { get; set; }
        public IDbSet<Story> Stories { get; set; }
        public IDbSet<Entry> Entries { get; set; }
        public IDbSet<Invitation> Invites { get; set; }
        public IDbSet<Vote> Votes { get; set; }
    }
}