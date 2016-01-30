using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Services.Models {
    public class EntryDTO {
        public int Id { get; set; }
        public string Content { get; set; }
        public int StoryId { get; set; }
        public ApplicationUserDTO Owner { get; set; }
        public IList<VoteDTO> Votes { get; set; }
        public bool Active { get; set; } = true;
    }
}