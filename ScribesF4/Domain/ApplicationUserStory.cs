using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Domain {
    public class ApplicationUserStory: IActivatable, IDbEntity {
        public int Id { get; set; }
        public ApplicationUser Writer { get; set; }
        public Story ThisStory { get; set; }
        public bool Active { get; set; } = true;
    }
}
