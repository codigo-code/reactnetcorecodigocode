using System;

namespace clase4interfaz{

    public class Accion : Pelicula
    {
        public void creditos()
        {
            Console.WriteLine("Super guachi guay");
            
        }

        public double duracion()
        {
           return 0.5;
        }

        public void saludo()
        {
            throw new NotImplementedException();
        }

        public void sasludo(){
            
        }
    }
}