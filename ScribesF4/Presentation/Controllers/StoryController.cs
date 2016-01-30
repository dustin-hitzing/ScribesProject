using ScribesF4.Domain;
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
    public class StoryController : ApiController {
        private StoryService _storyServ;
        
        public StoryController(StoryService storyServ) {
            _storyServ = storyServ;
        }
        [HttpGet]
        [Authorize]
        [Route("api/storyasdfgh/{storyId}")]
        public StoryDTO Get(int storyId) {
            return _storyServ.GetCurrentStory(storyId, User.Identity.Name);
        }

        [HttpPost]
        [Authorize]
        [Route("api/story/{storyId}")]
        public IHttpActionResult Post(int storyId, [FromBody] EntryDTO content) {
            if (ModelState.IsValid) {
                var newDTO = new EntryDTO {
                    Content = content.Content,
                    StoryId = storyId
                };
                return Ok(_storyServ.AddEntry(newDTO, User.Identity.Name));
            
            }
            return BadRequest();
           
        }
    }
}
