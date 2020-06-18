
using System;
using System.Collections.Generic;
using clase10WebApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace clase10WebApi.Controllers
{
    // Anotaciones van a ser decoradores de la clase 
    // en el cual complementen la funcionalidad

    [ApiController]
    [Route("[controller]")]
    public class PersonaController : ControllerBase
    {

        private static IList<Persona> lista = new List<Persona>();



        // especificar a cual de los endpoint invoco...
        [HttpGet("saludo")]
        public string saludo()
        {
            return "hola soy una persona";
        }

        [HttpGet("chauchau")]
        public string despedida()
        {
            return "nos vemos la proxima!";
        }


        [HttpGet("devuelvoPersona")]
        public Persona GetPersona()
        {

            Persona p = new Persona("Dante", 38, 1.92);
            p.agregoComida("ravioles");
            p.agregoComida("asado");
            p.agregoComida("cafe con leche");

            return p;
        }

        [HttpGet("getAllPersonas")]
        public IList<Persona> getAllPersonas()
        {

          
            return lista;
        }

        [HttpPost("guardarPersona")]
        public IActionResult savePersona([FromBody] Persona p)
        {
            try
            {
                lista.Add(p);
                return Ok("Guardado correcto");
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }


        }

    }
}