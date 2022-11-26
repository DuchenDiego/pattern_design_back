using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TiendaVirtualBackend.Models;

namespace TiendaVirtualBackend.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    // [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class VersionController : Controller
    {
        // GET: api/GetVersion
        [HttpGet("[action]")]
        public ActionResult GetVersion()
        {
            return Ok("1.0.0");
        }
    }
}
