using homework2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homework2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpPost("class")]
        public Dog Post1([FromBody] Dog dog)
        {
            string name = dog.name;
            int age = dog.age;
            string gennder = dog.gender;

            return dog;
        }

        [HttpPost("post2")]
        public IActionResult Post2([FromBody] Dog dog)
        {
            string name = dog.name;
            int age = dog.age;
            string gender = dog.gender;

            return Ok(dog);
        }
    }
}
