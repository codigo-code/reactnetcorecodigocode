

namespace clase4ioc
{

    public abstract class Pelicula
    {

        public string nombre { get; set; }

        public Pelicula(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract void creditos();

        public string saludoPostCreditos(Idioma idioma)
        {

            switch (idioma)
            {
                case Idioma.ESPANOL:
                    return "esto es todo amigos!";
                case Idioma.INGLES:
                    return " That's all folks!";
                case Idioma.PORTUGUES:
                    return "Estou e tod amigos";
                default:
                    return null;
            }

        }
    }
}