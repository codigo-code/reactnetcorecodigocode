using System;

namespace clase1
{

    public class CuentaSueldo
    {


        private double saldo = 10000; // almacena numeros negativas y positivos con punto decimal
                                      // 30.00 ---> 

        // get y set
        public void setSaldo(final double saldo){
            this.saldo = saldo;       
        }

        public void debitar( double valor){
            // logica de ver si el saldo es negativo 

        }

        public double getSaldo(){
            return this.saldo;
        }


    }
}

