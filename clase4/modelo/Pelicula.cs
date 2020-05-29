using System;

namespace clase4
{
    public abstract class Pelicula
    {
        public string nombre { get; set; }
        public double duracion { get; set; }
     
        public double presupuesto { get; set; }


        // 

        public abstract void mostrarCreditos();
    }

}