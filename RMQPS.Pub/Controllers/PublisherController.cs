using Microsoft.AspNetCore.Mvc;

namespace RMQPS.Pub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {

        [HttpPost]
        public IActionResult Post(string message)
        {
            return StatusCode(201);
        }
    }
}
