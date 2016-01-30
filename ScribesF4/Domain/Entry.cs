using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Domain {
    public class Entry: IDbEntity, IActivatable  {
        public int Id { get; set; }
        public string Content { get; set; }
        public Story Story { get; set; }
        public ApplicationUser Owner { get; set; }
        public IList<Vote> Votes { get; set; }
        public bool Active { get; set; } = true;
    }
}