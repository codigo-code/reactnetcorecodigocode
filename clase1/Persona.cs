using System;

namespace clase1
{ // espacio de trabajo donde voy a hacer interacturar mis clases
  // que tenga en el mismo espacio de trabajo
  // definir su comprotamiento o definir su razon de ser

    public class Persona
    { // scope 

        /*
            todo atributo tiene que privado pero debe ser accedido por medio
            de un metodo publico
        */

        // atributos
        public string nombre { get; set; }  


        // metodos
        public void dormir()
        {
            // instrucciones de forma secuencial 
            Console.WriteLine("Esta durmiendo " + nombre);
        }



        // fin del scope 
    }


}// definen el ambio o scope 