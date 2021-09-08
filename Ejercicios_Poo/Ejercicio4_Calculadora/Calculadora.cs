using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4_Calculadora
{
    class Calculadora
    {
        int priOperando;
        int segOperando;
        string operacionMat;

        public static int Calcular (int num1, int num2, string operando)
        {
            float resultado;
            switch (operando)
            {
                case "+":
                    {
                        resultado = num1 + num2;
                    }
                    break;
                case "-":
                    {
                        resultado = num1 - num2;
                    }
                    break;
                case "*":
                    {
                        resultado = num1 * num2;
                    }
                    break;
                case "/":
                    if (Calculadora.Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    break;
            }
        }

        private static bool Validar (int num2)
        {
             return num2 != 0;
        }


    }
}
