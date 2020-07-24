

using backend.DB;
using backend.modelo;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        [HttpPost("save")]  // localhost:5001/Usuario/ ---->
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

            Respuesta r = new Respuesta();
            using (var db = new MySQLContext())
            {
                var allUser = db.usuarioDB;

                r.activo = false;
                r.msj = "Usuario no encontrado";
                foreach (Usuario item in allUser)
                {
                    if (item.nombre == usuario.nombre && item.password == usuario.password)
                    {
                        r.usuario = item;
                        r.activo = true;
                        r.token = "abc123";
                        r.msj = "usuario correctamente autnticado";
                    }

                }
            }

            return Ok(r); // ---> 
        }

        [HttpGet]
        public IActionResult getAlgo()
        {
            return Ok("hola mundo");
        }
    }
}