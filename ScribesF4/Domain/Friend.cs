using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Domain {
    public class Friend {
        public int Id { get; set; }
        public ApplicationUser Individual { get; set; }
        public bool Active { get; set; }
    }
}