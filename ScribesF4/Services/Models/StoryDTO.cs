using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Services.Models {
    public class StoryDTO {
        public int Id { get; set; }
        public string Prompt { get; set; }
        public IList<ApplicationUserDTO> Authors { get; set; }
        public IList<EntryDTO> Entries { get; set; }
        public bool Active { get; set; } = true;
    }
}