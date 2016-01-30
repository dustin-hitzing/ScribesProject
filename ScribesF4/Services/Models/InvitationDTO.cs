using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Services.Models {
    public class InvitationDTO {
        public int Id { get; set; }
        public ApplicationUserDTO Sender { get; set; }
        public ApplicationUserDTO Recipient { get; set; }
        public bool Accepted { get; set; }
    }
}