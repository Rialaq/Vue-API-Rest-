using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotnetAPI_Hello_World.Models;

namespace DotnetAPI_Hello_World.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrueController : Controller
    {
        [HttpGet]
        public JsonResult Test()
        {
            var name = new List<names>
            {
                new names {NAME = "RICARDO", LAST_NAME = "ALMONTE" },
                new names {NAME = "MIGUEL", LAST_NAME = "ROJAS" },
                new names {NAME = "STARLING", LAST_NAME = "LEBRON" },
                new names {NAME = "FABIAN", LAST_NAME = "TRAVERAZ" }

            };
            return Json(name);
        }
    }
}