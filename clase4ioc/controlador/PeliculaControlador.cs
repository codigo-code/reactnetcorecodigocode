using System;

namespace clase4ioc{


    public class PeliculaControlador{



        private Pelicula pelicula;


        public PeliculaControlador(Pelicula pelicula){
            // de alguna manera vendra la instancia
            this.pelicula= pelicula;
        }



        public void saludo(Idioma idioma){

            Console.WriteLine(this.pelicula.saludoPostCreditos(idioma));

        }


        public void muestroCreditos(){
            Console.WriteLine("Usted vio la pelicula : " + this.pelicula.nombre);
            this.pelicula.creditos();
        }


    }
}