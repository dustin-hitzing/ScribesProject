using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Domain {
    public class Vote {
        public int Id { get; set; }
        public ApplicationUser Voter { get; set; }
        public bool Acceptable { get; set; }

    }
}