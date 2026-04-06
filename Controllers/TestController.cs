using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMappersDemo;

namespace AutoMappersDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {

        // GET: TestController/Traditional
        [HttpGet("Traditional")]
        public EmployeeDTO Traditional()
        {
            return Business.TraditionalApproach();
        }
    }
}
