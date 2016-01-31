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
    public class CreateController : ApiController
    {
        public StoryService _storyServ;
        public CreateController(StoryService storyServ) {
            _storyServ = storyServ;
        }
        [HttpPost]
        [Route("api/create")]
        public IHttpActionResult Post(NewStoryDTO prompt) {
            if (ModelState.IsValid) {
                _storyServ.AddNewStory(prompt, User.Identity.Name);
                return Ok();
            }
            return BadRequest();
        }
    }
}
