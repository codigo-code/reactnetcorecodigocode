
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace clase5web.Pages.peliculas
{

    public class PeliculaModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string nombre { get; set; }

        private static IList<PeliculaDTO> listaPelicula = new List<PeliculaDTO>();



        [BindProperty]
        public PeliculaDTO objPelicula { get; set; }

        // [BindProperty(SupportsGet = true)]
        // public int id { get; set; }


        public void OnGet()
        {
            if (objPelicula != null)
                Console.WriteLine(objPelicula.nombre + " " + objPelicula.isbn);

            return; // Ok(objPelicula);
        }

        public ActionResult OnPost()
        {
            listaPelicula.Add(objPelicula);

            Console.WriteLine("Guardamos la pelicula " + objPelicula.nombre + ", cantidad la lista Pelicula-->" + listaPelicula.Count);

            return RedirectToPage("/peliculas/mostrarPelicula", objPelicula);
        }
    }
}