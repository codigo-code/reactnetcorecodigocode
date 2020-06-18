

using System.Collections.Generic;
using clase8mvc.DTO;
using clase8mvc.Entities;
using clase8mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace clase8mvc.Controllers
{

    public class PeliculaController : Controller
    {
        public IList<PeliculaModel> listaPeliculas = new List<PeliculaModel>();

        public IActionResult ListaPelicula()
        {
            // agrego la logica ... q se la envio a la vista
            // lo consumimos del modelo

            //Dictionary key -- value 
            PeliculaModel peli1 = new PeliculaModel("MIB", 1997);

            listaPeliculas.Add(peli1);
            listaPeliculas.Add(new PeliculaModel("Matrix", 1999));
            listaPeliculas.Add(new PeliculaModel("El extraño mundo de jack", 1993));



            using (var conx = new MySqlContext())
            {
                conx.peliculaEntities.Add(new PeliculaEntity
                {
                    nombre = peli1.nombre,
                    fechaDeLanzamiento = peli1.relese.ToString()
                });

                conx.SaveChanges();
            }



                ViewData["PeliculaNombre"] = listaPeliculas;
                return View();
            }
        }
    }