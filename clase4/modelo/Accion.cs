using System;

namespace clase4
{
    // dos puntos sirve para extender e implementar 
    // clase abstract y/o N interfaces
    /*
        Puedo extender de una sola clase 
        Puedo implementar multiples interfaces
    */
    public class Accion : Pelicula
    {
        
        public override void mostrarCreditos()
        {
            Console.WriteLine("Gracias por ver esta peli de accion");
        }

       
    }
}