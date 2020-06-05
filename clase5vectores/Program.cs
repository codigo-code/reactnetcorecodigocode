using System;
using System.Collections;
using System.Collections.Generic;

namespace clase5vectores
{
    class Program
    {
        static void Main(string[] args)
        {

            // Persona p = new Persona();
            Persona[] vecPersona = new Persona[10]; // <--- 

            string[] nombres = { "braian", "marcos", "ivana", "daniela", "matias", "alejo", "ricardo", "lucas", "alejo", "pablo", "camila" };

            int indice = 5;
            // nombres ---> indice --> 

            // Console.WriteLine("El nombre de la posicion " + indice + " es: " + nombres[indice]);

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("El nombre de la posicion " + i + " es: " + nombres[i]);
            }

            // REF Posicion ---> arranca desde 1 y da el valor simbolico del vector / lista
            // REF Indice ---> arranca de 0 y nos da el valor donde esta alojado el objeto 

            vecPersona[0] = new Persona();

            vecPersona[1] = new Persona("dante", "panella");

            vecPersona[0].nombre = "Magali";
            vecPersona[0].apellido = "Panella";

            Console.WriteLine(vecPersona[0].nombre);
            Console.WriteLine(vecPersona[1].nombre);
            Console.WriteLine(vecPersona[2].nombre); // null.nombre    


            // lista de personas 
            IList<Persona> listaPersona = new List<Persona>();
            listaPersona.Add(new Persona("Mariana", "Panella"));
            listaPersona.Add(new Persona("Cecilia", "Dominguez"));


            foreach (Persona item in listaPersona)
            {
                Console.WriteLine(item.nombre + "," + item.apellido);
            }


        }
    }
}
