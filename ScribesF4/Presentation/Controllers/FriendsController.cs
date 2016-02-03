using ScribesF4.Services;
using ScribesF4.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ScribesF4.Presentation.Controllers
{
    public class FriendsController : ApiController
    {
        public FriendsService _friendServ;
        public FriendsController(FriendsService friendServ) {
            _friendServ = friendServ;
        }
        //[Authorize]
        //public IList<FriendDTO> GetFriends() {
        //    return _friendServ.ListFriends(User.Identity.Name);
        //}
        [HttpGet]
        [Authorize]
        [Route("api/users/{searchTerm}")]
        public IList<ApplicationUserDTO> SearchUsers(string searchTerm) {
            return _friendServ.ListUsers(searchTerm);
        }
    }
}
