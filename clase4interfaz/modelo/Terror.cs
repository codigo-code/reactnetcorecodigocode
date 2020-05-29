using System;

namespace clase4interfaz{

    public class Terror : Pelicula , Elenco
    {
        public void creditos()
        {
            Console.WriteLine("Salimos con popi en los pantis");
            
        }

        public string director()
        {
            
          return "ivana";
        }

        public double duracion()
        {
            return 2.0;
        }

        public void elencoPrincipal()
        {
           
            Console.WriteLine("Alejo y Pablo");
        }

        public void saludo(){
            
        }
    }
}