

using System.ComponentModel.DataAnnotations.Schema;

namespace clase8mvc.Entities
{
    [Table("peliculas")]
    public class PeliculaEntity
    {

        public int id { get; set; }

        public string nombre { get; set; }

        [Column("releaseDate")]
        public string fechaDeLanzamiento { get; set; }

       

    }
}