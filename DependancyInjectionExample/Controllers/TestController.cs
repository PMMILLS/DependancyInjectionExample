using System.Collections.Generic;
using BusinessObjects.Interfaces;
using Microsoft.AspNetCore.Mvc;
using static DependancyInjectionExample.Common.ServiceInjection;

namespace DependancyInjectionExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IService _aService;

        public TestController(ServiceResolver<IService> serviceAccessor)
        {
            _aService = serviceAccessor(false);
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string>() { _aService.DoTheThing() };
        }
    }
}
