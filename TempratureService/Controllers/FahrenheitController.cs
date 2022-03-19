using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
namespace TempratureService.Controllers
{
    [Route("[controller]")]
    public class FahrenheitController : ControllerBase
    {
        [HttpGet("{locationId}")]
        public ActionResult Get(int locationId)
        {
            return StatusCode((int)HttpStatusCode.InternalServerError, "Something went wrong when getting the tempratire in Farehnit");
        }
    }
}
