using Microsoft.AspNetCore.Mvc;

namespace Assignment_6.Controllers
{
    [ApiController]
    [Route("[controller]")]
    
    public class HomeController : ControllerBase
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "Name")]
        public IActionResult Get()
        {
            var personName = new Name { PersonName = "Jackson Pinchot" };
            return Ok(personName);
        }
    }
}
