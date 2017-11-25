using Microsoft.AspNetCore.Mvc;
using USA.Helpers;

namespace USA.Controllers
{
    [Route("api/[controller]")]
    public class PresidentsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(PresidentHelper.GetAllPresidents());
        }
    }
}
