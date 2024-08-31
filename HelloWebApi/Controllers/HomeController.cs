using HelloWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWebApi.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetMessage()
        {
            {
                var result = new ResponseModel()
                {
                    HttpStatusCode = 200,
                    Message = "Hello World!"
                };

                return Ok(result);
            }
           
        }
    }
}
