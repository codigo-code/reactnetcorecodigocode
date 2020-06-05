namespace clase5vectores
{

    public class Persona
    {

        public string nombre { get; set; }
        public string apellido { get; set; }

        // sobre-carga de constructores

        public Persona() { }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }
    }
}