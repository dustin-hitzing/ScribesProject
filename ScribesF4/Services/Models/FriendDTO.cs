﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScribesF4.Services.Models {
    public class FriendDTO {
        public int Id { get; set; }
        public ApplicationUserDTO Individual { get; set; }
        public bool Active { get; set; }
    }
}