using System;

namespace clase4ioc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PeliculaControlador pc = new PeliculaControlador(new Terror("The ring"));

            pc.muestroCreditos();
            pc.saludo(Idioma.PORTUGUES);
        }
    }
}
