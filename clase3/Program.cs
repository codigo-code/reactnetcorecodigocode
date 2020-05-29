using System;

namespace clase3
{
    class Program
    {
   
 

        static void Main(string[] args)
        {
            

            Console.WriteLine("Capa Vista");
            Console.WriteLine("Mi segunda aplicacion en c# netCore");


            Pizza p1 = new Pizza("molde", "tomate", "muzzarella", 20.5); // crear objetos
            Pizza p3 = crearPizza("molde", "tomate", "queso fontina", 20.5);


            Console.WriteLine(idintificoPizza(p1));
            Console.WriteLine(idintificoPizza(p3));


            Muzzarela m1 = new Muzzarela();
            m1.tipoMaza = "piedra";
            m1.ingrediente1 = "arroz";
            m1.ingrediente2 = "muzarella";

            m1.cocionar(20.0);

            // factoria abstract ---> factoria de metodos
            Pizza p4 = new Muzzarela();





        }


        public static string idintificoPizza(Pizza pizza)
        {
            string resultado = "No tengo idea de que pizza es :(";

            // aplicar condiciones para resolver o deducir de que tipo es la pizza
            if (pizza.tipoMaza == "molde" && pizza.ingrediente2 == "muzzarella")
            {
                resultado = "Grande de muzza";
            }
            return resultado;
        }


        // como se construye la pizza

        // Builder 
        public static Pizza crearPizza(string tipoMaza, string ingrediente1, string ingrediente2, double tamano)
        {
            
            // void hace referencia a un proceso 
            Pizza pizza = new Pizza(); // <--- Creo la pizza

            pizza.tipoMaza = tipoMaza;
            pizza.ingrediente1 = ingrediente1;
            pizza.ingrediente2 = ingrediente2;
            pizza.tamano = tamano;

            return pizza;

            // fin del procesamiento ---> imprimira o modificar alguna variable interna o externa al proceso
        }
 
    }
}
