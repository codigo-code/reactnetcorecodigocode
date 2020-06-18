

using System.Collections.Generic;

namespace clase10WebApi.Model
{
    public class Persona
    {

        public string nombre { get; set; }
        public int edad { get; set; }
        public double altura { get; set; }
        public IList<string> comidasFavoritas { get; set; }

        public Persona(string nombre, int edad, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.altura = altura;
            this.comidasFavoritas = new List<string>();
        }

        public Persona(){}

        public void agregoComida(string comida)
        {
            this.comidasFavoritas.Add(comida);
        }
    }
}






