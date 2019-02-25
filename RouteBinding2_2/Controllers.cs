using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RouteBinding2_1
{
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet("/api/nobind/{value}/{subValue}")]
        public IActionResult NoBind([FromRoute] RouteModel value)
        {
            return Ok(value);
        }
        [HttpGet("/api/bind/{value}/{subValue}")]
        public IActionResult Bind([FromRoute] RouteModel value1)
        {
            return Ok(value1);
        }

        
    }

    public class MvcController : ControllerBase
    {
        [HttpGet("/mvc/nobind/{value}/{subValue}")]
        public IActionResult NoBind([FromRoute] RouteModel value)
        {
            return Ok(value);
        }
        [HttpGet("/mvc/bind/{value}/{subValue}")]
        public IActionResult Index([FromRoute] RouteModel value1)
        {
            return Ok(value1);
        }

        
    }

    public class RouteModel
    {
        public string Value { get; set; }
        public string SubValue { get; set; }
    }
}
