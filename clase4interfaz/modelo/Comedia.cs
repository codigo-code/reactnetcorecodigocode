using System;

namespace clase4interfaz
{
    public class Comedia : Pelicula, Elenco
    {
        public void creditos()
        {

            Console.WriteLine("Cuantas risas jajaja jeje XD");
        }

        public string director()
        {

            return "lucas y mati1 y 2 ";
        }

        public double duracion()
        {
            return 1.0;
        }

        public void elencoPrincipal()
        {
            Console.WriteLine("Brian marcos, dani, ricardo");
        }

        public void saludo()
        {
            throw new NotImplementedException();
        }
    }
}