

using System.ComponentModel.DataAnnotations.Schema;

namespace backend.modelo
{

    [Table("usuarios")]
    public class Usuario
    {

        [Column]
        public int id { get; set; }

        [Column]
        public string nombre { get; set; }
        [Column]
        public string password { get; set; }

        [Column]
        public string mail { get; set; }
    }
}