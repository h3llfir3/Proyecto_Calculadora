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

        public static void PrintFibonacci(int n)
        {
            int number1 = 0;
            int number2 = 1;
            int nf = 0;
            Console.WriteLine(number1 + ", " + number2);
            for (int i = 0; i < n; i++)
            {
                nf = number1 + number2;
                Console.WriteLine(nf + ", ");
                number1 = number2;
                number2 = nf;
            }
        }
    }
}
