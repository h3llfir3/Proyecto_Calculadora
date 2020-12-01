using System;
using System.IO.Compression;

namespace Calculadora.Model
{
    class Maths
    {
        /// <summary>
        /// The method CalPowerOf2 raises base 2 to an integer exponent n (that is, to calculate the value 2^n)
        /// </summary>
        /// <param name="n">Used as the exponent.</param>
        /// <returns>Returns the result of 2 raised to the nth power.</returns>
        public static int CalcPowerOf2(int n)
        {
            int accumulated = 1;
            for (int i = 0; i < n; i++)
                accumulated *= 2;
            return accumulated;
        }

        /// <summary>
        /// The method CalcSummatory calculates the summatory of an integer n.
        /// </summary>
        /// <param name="n">Indicates the number of which to calculate the summatory.</param>
        /// <returns>Returns the sum of a sequence of numbers.</returns>
        public static int CalcSummatory(int n)
        {
            int accumulated = 0;
            for (int i = 0; i <= n; i++)
                accumulated += i;
            return accumulated;
        }
        
        /// <summary>
        /// The method CalcFactorial calculates the factorial of an integer n.
        /// </summary>
        /// <param name="n">Indicates the number of which to calculate the factorial.</param>
        /// <returns>Returns the multiplication of a sequence of numbers.</returns>
        public static int CalcFactorial(int n)
        {
            int accumulated = 1;
            for (int i = 1; i <= n; i++)
                accumulated *= i;
            return accumulated;
        }

        /// <summary>
        /// The method IsPrime calculates whether an integer n is a prime number or not.
        /// </summary>
        /// <param name="n">The number to check if it's a prime number.</param>
        /// <returns>Returns true if the number is prime. Returns false if the number is not prime.</returns>
        public static bool IsPrime(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if ((n % i) == 0)
                    return false;
            }
            return true;
        }

        /// <summary>
        /// The method PrintFibonacci calculates the sequence of Fibonacci up until the integer n.
        /// </summary>
        /// <param name="n">Indicates the amount of numbers from the sequence to show.</param>
        /// <returns>Returns a string containing the numbers in the sequence.</returns>
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
                serie += number1.ToString() + ", " + number2.ToString();
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
