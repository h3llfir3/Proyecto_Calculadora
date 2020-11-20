using System;
using System.IO.Compression;

namespace Calculadora.Model
{
    class Maths
    {
        // Calcula una potencia en base 2
        public static int CalcPowerOf2(int n)
        {
            int accumulated = 1;
            for (int i = 0; i < n; i++)
                accumulated *= 2;
            return accumulated;
        }

        // Calcula el sumatorio de un número
        public static int CalcSummation(int n)
        {
            int accumulated = 0;
            for (int i = 0; i <= n; i++)
                accumulated += i;
            return accumulated;
        }
        
        // Calcula el factorial de un número
        public static int CalcFactorial(int n)
        {
            int accumulated = 1;
            for (int i = 1; i <= n; i++)
                accumulated *= i;
            return accumulated;
        }

        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if ((n % i) == 0)
                    return false;
            }
            return true;
        }

        public static string PrintFibonacci(int n)
        {
            int number1 = 0;
            int number2 = 1;
            string serie = "";
            
            if (n <= 0)
                return serie += "La entrada no es válida.";
            else if (n == 1)
                return serie += number1.ToString();
            else if (n == 2)
                return serie += number1.ToString() + ", " + number2.ToString();
            else
            {
                Console.Write(number1 + ", " + number2);
                for (int i = 0; i < n; i++)
                {
                    int nf = number1 + number2;
                    number1 = number2;
                    number2 = nf;
                    serie += ", " + nf.ToString();
                }
                return serie;
            }
        }
    }
}
