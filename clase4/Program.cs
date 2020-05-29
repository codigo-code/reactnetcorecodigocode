using System;

namespace clase4
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Creando peliculas");

            // Toda clase abstra no se puede instanciar a si misma
            // variable de forma estatica   ----> new ---> instancia en memoria

            // Pelicula peli1 = new Terror();

            // peli1.nombre = "Pixel";

            // Console.WriteLine(" tipo  " + peli1.GetType().Name + " nombre de la pelicula " + peli1.nombre);

            // Console.WriteLine("Corregimos el error de catalogar a la peli");
            
            // peli1 = new Comedia(); // generar el nuevo espacio en memoria ---> todos sus atributos son nulos o vacios 
            
            // peli1.nombre = "Pixel";

            // Console.WriteLine(" tipo  " + peli1.GetType().Name + " nombre de la pelicula " + peli1.nombre);

            // peli1.mostrarCreditos();

            PeliculaControlador pc = new PeliculaControlador();

            Pelicula peli2= pc.creoPelicula(Genero.TERROR);

            Console.WriteLine(peli2.GetType().Name);
        }

    }
}
