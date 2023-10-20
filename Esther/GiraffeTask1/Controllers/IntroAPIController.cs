using GiraffeTask1.Models;
using Microsoft.AspNetCore.Mvc;

namespace GiraffeTask1.Controllers
{
    [Route("api/IntroAPI")]
    [ApiController]
    public class IntroAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable <Intro> GetIntro()
        {
            return new List<Intro>
            {
               new Intro{Name = "Esther", Pet = "Coffee", Birth = 0722 }
            };
        }
    }
}
