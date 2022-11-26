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
    public class UserController : Controller
    {
        // GET: api/UserExists
        [HttpPost("[action]")]
        public ActionResult UserExists([FromBody] Usuarios _user)
        {
            if(_user.Usuario == "jmedina" || _user.Usuario == "bduchen")
                return Ok("Existe");
            else
                return BadRequest("No existe");
            // return _context.User.Any(e => e.IdUser == id);
        }
    }
}
