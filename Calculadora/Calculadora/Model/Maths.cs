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
            int i = 2;
            while (i < n)
            {
                if ((n % i) == 0)
                    return false;
                i++;
            }
            return true;
        }
    }
}
