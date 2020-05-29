using System;
namespace clase4ioc
{
    public class Terror : Pelicula
    {
        public Terror(string nombre) :
         base(nombre)
        {
             
        }

        public override void creditos()
        {
            Console.WriteLine("Creditos para la peli de terror");
        }

      
      
    }
}