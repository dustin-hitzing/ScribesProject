using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Services.Models {
    public class ApplicationUserDTO {
        public string Id { get; set; }
        public string UserName { get; set; }
        public IList<FriendDTO> Friends { get; set; }
        public IList<StoryDTO> Stories { get; set; }
        public IList<EntryDTO> Entries { get; set; }
        public IList<InvitationDTO> Invites { get; set; }
        public IList<VoteDTO> Votes { get; set; }
        public bool Active { get; set; } = true;
    }
}