using System;

namespace Calculadora
{
    class UserInterface
    {
        /// <summary>
        /// The method PrintMainMenu prints the elements that comprise the main menu.
        /// </summary>
        public static void PrintMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("            MENÚ PRINCIPAL");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
            Console.WriteLine("1) Potencia en base 2.");
            Console.WriteLine("2) Sumatorio de un número.");
            Console.WriteLine("3) Factorial de un número.");
            Console.WriteLine("4) Calcular si el número es primo.");
            Console.WriteLine("5) Imprimir la serie de Fibonacci.");
            Console.WriteLine("0) Salir del programa.");
            Console.WriteLine();
        }

        /// <summary>
        /// The method PrintPowerOf2Menu prints the title of the power of 2 menu.
        /// </summary>
        public static void PrintPowerOf2Menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("         POTENCIAS EN BASE 2");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// The method PrintSummatoryMenu prints the title of the summatory menu.
        /// </summary>
        public static void PrintSummatoryMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("        SUMATORIO DE UN NÚMERO");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// The method PrintFactorialMenu prints the title of the factorial menu.
        /// </summary>
        public static void PrintFactorialMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("        FACTORIAL DE UN NÚMERO");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// The method PrintPrimeMenu prints the title the prime number menu.
        /// </summary>
        public static void PrintPrimeMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("              ¿ES PRIMO?");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// The method PrintFibonacciMenu prints the title of the fibonacci menu.
        /// </summary>
        public static void PrintFibonacciMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("           SERIE FIBONACCI");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();
        }


        /// <summary>
        ///  The method GetUserIntegerInput takes a string from the user and converts it to an integer.
        /// </summary>
        /// <param name="integerInput">This is the string to convert.</param>
        /// <returns>Returns the user input converted into an integer.</returns>
        public static int GetUserIntegerInput(string integerInput)
        {
            while (true)
            {
                Console.WriteLine(integerInput);
                string number = Console.ReadLine();
                try
                {
                    int convertedInteger = Convert.ToInt32(number);
                    return convertedInteger;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Entrada no válida.");
                }
            }
        }
        /// <summary>
        /// The method ReadUserInput gets a string from the user and converts it to an integer.
        /// </summary>
        /// <returns>Returns the integer the user entered, or in case of an invalid input, -1 to trigger an error message.</returns>
        public static int ReadUserOption()
        {
            string option = Console.ReadLine();
            try
            {
                int userOption = Convert.ToInt32(option);
                return userOption;
            }
            catch (Exception e)
            {
                //e.Message;
                return -1;
            }
        }

        /// <summary>
        /// The method ExitSubMenu prints a message and waits for the user 
        /// to press the Enter key and clears the console once Enter is pressed.
        /// </summary>
        public static void ExitSubMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Pulse \"Intro\" para finalizar.");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
