using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DOTNET_WEB_01.Models;
using DOTNET_WEB_01.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnet_web_01.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SumController : ControllerBase
    {
        [HttpPost("Sum")]
        public ActionResult Sum(InputValuesSum request)
        {
            try
            {
                var response = new SumService().Calculator(request);

                return Ok(response); 
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message); 
            }
        }
    }
}