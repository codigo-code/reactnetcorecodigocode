

using System;
using System.Collections.Generic;
using backend.DB;
using backend.modelo;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {

        [HttpPost]
        public IActionResult getAllProductos([FromBody] Token token)
        {
            Console.WriteLine(token.credencial);
            if (token.credencial.Equals("abc123"))
            {
                RespuestaProducto r = new RespuestaProducto();

                r.listaProducto = new List<Producto>();
                r.mensaje = "Productos encontrados";

                using (var obj = new MySQLContext())
                {
                    var resList = obj.productoDB;

                    foreach (var item in resList)
                    {
                        r.listaProducto.Add(item);

                    }
                }
                return Ok(r);
            }
            else
            {
                return Ok("No no es");
            }

        }
    }
}