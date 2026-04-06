using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMappersDemo;

namespace AutoMappersDemo.Controllers
{
    public class TestController : Controller
    {

        // GET: TestController/Traditional
        public EmployeeDTO Traditional()
        {
            return Business.TraditionalApproach();
        }
    }
}
