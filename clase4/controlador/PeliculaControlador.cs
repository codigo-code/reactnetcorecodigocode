

namespace clase4
{

    public class PeliculaControlador
    {


        // Factoria de metodos 
        // ObjetoAbstracto variable = new ClaseHerencia();
        public Pelicula creoPelicula(Genero genero)
        {

            switch (genero)
            {
                case Genero.ACCION:
                    return new Accion();  // statament ---> 

                case Genero.COMEDIA:
                    return new Comedia();
                    
                case Genero.TERROR:
                    return new Terror();

                default:
                    return null;
            }
        }
    }
}