using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
   
    public class valuesController : ControllerBase
    {


        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] {"Rafik","Sami","London"};
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "SYN Test" ;
        }
    }
}