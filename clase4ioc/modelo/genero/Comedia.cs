using System;

namespace clase4ioc
{
    public class Comedia : Pelicula
    {
        public Comedia(string nombre) :
         base(nombre)
        {

        }

        public override void creditos()
        {
            Console.WriteLine("Creditos para la peli de Comedia");
        }



    }
}