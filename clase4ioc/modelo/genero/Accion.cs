using System;
namespace clase4ioc
{
    public class Accion : Pelicula
    {
        public Accion(string nombre) :
         base(nombre)
        {
             
        }

        public override void creditos()
        {
           Console.WriteLine("Creditos para la peli de Acciion ");
        }

      
      
    }
}