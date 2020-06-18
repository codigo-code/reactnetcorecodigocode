

namespace clase8mvc.Models
{
    public class PeliculaModel
    {
        public string nombre { get; set; }
        public int relese { get; set; }


        public PeliculaModel(string nombre, int relese)
        {
            this.nombre=nombre;
            this.relese=relese;
        }
    }
}