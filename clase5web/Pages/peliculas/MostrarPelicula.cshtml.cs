

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace clase5web.Pages.peliculas
{


    public class MostrarPeliculaModel : PageModel
    {


        [BindProperty(SupportsGet = true)]
        public string nombre { get; set; }

        [BindProperty(SupportsGet = true)]
        public int isbn { get; set; }

        [BindProperty(SupportsGet = true)]
        public string genero { get; set; }




        public void OnGet()
        {

        }

    }
}