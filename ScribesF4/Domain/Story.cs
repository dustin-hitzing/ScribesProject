using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Domain {
    public class Story: IDbEntity, IActivatable {
        public int Id { get; set; }
        public string Prompt { get; set; }
        public IList<ApplicationUser> Authors { get; set; }
        public IList<Entry> Entries { get; set; }
        public bool Active { get; set; } = true;
    }
}