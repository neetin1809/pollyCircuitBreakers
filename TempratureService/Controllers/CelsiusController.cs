using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace TempratureService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CelsiusController : ControllerBase
    {
        static int _counter = 0;
        static readonly Random random = new Random();

        [HttpGet("{locationId}")]
        public ActionResult Get(int locationId)
        {
            _counter++;
            if(_counter % 4 == 0)
            {
                return Ok(random.Next(0, 100));
            }
            return StatusCode((int)HttpStatusCode.InternalServerError, "Something went wrong when getting the temperature.");
        }

    }
}
