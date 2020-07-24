

namespace backend.modelo
{

    public class Respuesta
    {
        public string token { get; set; }
        public Usuario usuario { get; set; }

        public bool activo { get; set; }

        public string msj { get; set; }

    }
}