using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Services.Models {
    public class VoteDTO {
        public int Id { get; set; }
        public ApplicationUserDTO Voter { get; set; }
        public bool Acceptable { get; set; }
    }
}