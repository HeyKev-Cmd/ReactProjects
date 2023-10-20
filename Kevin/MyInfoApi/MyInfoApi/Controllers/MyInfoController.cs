using Microsoft.AspNetCore.Mvc;

namespace MyInfoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyInfoController : ControllerBase
    {
        

        private readonly ILogger<MyInfoController> _logger;

        public MyInfoController(ILogger<MyInfoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetMyInfo")]
        public IEnumerable<MyInfo> Get()
        {
            var myInfoList = new List<MyInfo>
            {
                new MyInfo
                {
                    Date = DateTime.Now,
                    FirstName = "Kevin",
                    LastName = "Chou",
                    Gender = "Male"
                },
            };

            return myInfoList;
        }
    }
}