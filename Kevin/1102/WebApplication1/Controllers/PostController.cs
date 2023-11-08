using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;
using WebApplication1.Modules;
namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private static List<post> posts = new List<post>();

        [HttpPost("AddPost")]
        public IActionResult AddPost([FromBody] post post)
        {
                 
            if (post == null)
            {
                return BadRequest("Error in arguments"); 
            }
            else
            {
                posts.Add(post);
                return Ok("Post is added with id="+ (posts.Count - 1).ToString());
            }
           


        }
        [HttpGet( "GetPost")]
        public IActionResult GetPost()
        {
            return Ok(posts);
        }
        [HttpPost("Like")]
        public IActionResult Like([FromForm]int id)
        {
            if (id <= posts.Count)
            {
                posts[id].like_count += 1;
                return Ok("Like success");
            }
            else
            {
                return NotFound("Can't find with post id");
            }
        }
        [HttpDelete("DeletePost")]
        public IActionResult DeletePost([FromForm] int id)
        {
            if (id <= posts.Count)
            {
                posts.RemoveAt(id);
                return Ok("Delete success");
            }
            else
            {
                return NotFound("Can't find with post id");
            }
        }
        [HttpPut("UpdatePost")]
        public IActionResult UpdatePost([FromForm] int id,string new_content)
        {
            if (id <= posts.Count)
            {
                posts[id].content= new_content;
                return Ok("Update success");
            }
            else
            {
                return NotFound("Can't find with post id");
            }
        }
    }

}
