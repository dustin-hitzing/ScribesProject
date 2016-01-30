using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScribesF4.Domain {
    public class Invitation {
        public int Id { get; set; }
        [Key]
        public ApplicationUser Sender { get; set; }
        public ApplicationUser Recipient { get; set; }
        public bool Accepted { get; set; }
        
    }
}