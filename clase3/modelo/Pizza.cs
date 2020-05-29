using System;

namespace clase3
{
    // visibiladad tipo nombre (Empieza en mayusc y tiene que tener el mismmo nombre del arciv )
    public class Pizza
    {

        // encapsulamiento
        public string tipoMaza { get; set; } // pieda , medio molde , molde 

        public double tamano { get; set; }

        public string ingrediente1 { get; set; }
        public string ingrediente2 { get; set; }


        // constructores --> es decir como se inicializa el objeto
        /*
            Debe tener el mismo nombre de la clase pero no debe tener nombre de un metodo


        */
        public Pizza(string tipoMaza, string ingrediente1, string ingrediente2, double tamano){
            this.tipoMaza = tipoMaza;
            this.ingrediente1=ingrediente1;
            this.ingrediente2=ingrediente2;
            this.tamano=tamano;
        }

        // sobrecarga de constructor
        public Pizza(){}

        // como quiero que interacture

    }
}