

using backend.DB;
using backend.modelo;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        [HttpPost]
        public IActionResult saveUsuario([FromBody] Usuario usuario)
        {

            using (var db = new MySQLContext())
            {
                db.usuarioDB.Add(usuario);
                db.SaveChanges();

            } // close connection  

            return Ok("guardoOK");
        }

        [HttpPost("checkUser")]
        public IActionResult checkeUser([FromBody] Usuario usuario)
        {

            Usuario u = new Usuario();
            using (var db = new MySQLContext())
            {
                var allUser = db.usuarioDB;
                foreach (Usuario item in allUser)
                {
                    if (item.nombre == usuario.nombre && item.password == usuario.password)
                    {
                        u = item;
                    }
                }
            }

            return Ok(u);
        }
    }
}