using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoPotencias
{
    public class Matem
    {
        public Matem() { }

        public double Potencia(double pArgumento, int pExponete )
        {
            int exponete = pExponete;
            double resultado = 1; // elemento neutro para la multiplicacion

            while (exponete != 0)
            {
                if (exponete > 0)
                { 
                    resultado = resultado * pArgumento;
                    exponete = exponete - 1;
                }
                if (exponete < 0)
                {
                    resultado = resultado / pArgumento;
                    exponete = exponete + 1;
                }
            }
            return resultado;
        }
    }
}
