using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace homework2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetController : ControllerBase
    {
        [HttpGet("header")]
        public string Get1([FromHeader] string name, [FromHeader] int age, [FromHeader] string gender)
        {
            return string.Format("name:{0}, age:{1}, gender{2}", name, age, gender);
        }

        [HttpGet("Action")]
        public IActionResult Get2([FromHeader] string name, [FromHeader] int age, [FromHeader] string gender)
        {
            return Ok(string.Format("name:{0}, age:{1}, gender{2}", name, age, gender));
        }
    }
}
