using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMappersDemo;

namespace AutoMappersDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        private readonly Business _business;

        public TestController(Business business)
        {
            _business = business;
        }

        // GET: TestController/Traditional
        [HttpGet("Traditional")]
        public IActionResult GetTraditional()
        {
            return Ok(Business.TraditionalApproach());
        }

        [HttpGet("auto")]
        public IActionResult GetAutoMapped()
        {
            var result = _business.AutoMapper();
            return Ok(result);
        }
    }
}
