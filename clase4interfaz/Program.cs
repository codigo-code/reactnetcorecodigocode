using System;

namespace clase4interfaz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pelicula  peli1 = new Terror();

            // de momento trabajamos con sus metodos
            peli1.creditos();

            Pelicula peli2 = new Comedia();

            Pelicula peli3 = new Terror();

            Elenco elen = new Terror();
        }
    }
}
