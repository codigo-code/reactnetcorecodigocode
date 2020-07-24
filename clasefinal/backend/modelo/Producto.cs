

using System.ComponentModel.DataAnnotations.Schema;

namespace backend.modelo
{



    [Table("productos")]
    public class Producto
    {

        public int id { get; set; }

        public string nombre { get; set; }

        public double precio { get; set; }

        public string imagen { get; set; }
    }
}