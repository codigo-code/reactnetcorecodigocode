using System;


namespace clase1
{
    public class Program
    {
        /*
            Comentario es lo que el compilador va a ignorar
            Punto de salida 
            asdasdasd

            main es el punto de salida de nuestro programa , por donde se ejecuta
        */
        static void Main(string[] args)  // ---> esto es un metodo
        { // scope o ambito del metodo

            Console.WriteLine("hola mundo mi primer ejercicio basico con netcore");
            Console.WriteLine("Creamos una persona 1 ");


            Persona p1 = new Persona();
            p1.nombre = "Lucas";

            p1.dormir();

            Console.WriteLine("Creamos una persona 2 ");
            Persona p3 = new Persona();
            p3.nombre = "Ivana";
            p3.dormir();

            string nombre = "dante";
            Console.WriteLine("Muestro una variable string por consola : " + nombre);

            CuentaSueldo cs1 = new CuentaSueldo();
            Console.WriteLine("Cuando se crea el obj -> " + cs1.getSaldo());
            // cs1.setSaldo(metodoMalisioso(10000)); = 
            
            // Console.WriteLine("Despues del metodo malisioso " + cs1.saldo);
            // procedimentos y funciones    
        } // fin de su metodo


        //contrato y firma
        public static double metodoMalisioso(double valor)
        {
            double resultado = valor - 100000;
            Console.WriteLine("Se ejecuta el metodo maligno " + resultado);
            return resultado ;
        }

    }
}
