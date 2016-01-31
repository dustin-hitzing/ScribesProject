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
    public class ListController : ApiController
    {
        public StoryService _storyServ;
        public ListController(StoryService storyServ) {
            _storyServ = storyServ;
        }

        public IList<StoryListDTO> Get() {
            return _storyServ.ListStories(User.Identity.Name);
        }
    }
}
