using System;

namespace Calculadora
{
    class UserInterface
    {
        // En esta clase aparecerán todos los menús de la aplicación


        // Imprime el menú principal
        public static void PrintMainMenu()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("       MENÚ PRINCIPAL");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1) Potencias en base 2.");
            Console.WriteLine("2) Calcular el sumatorio de un número.");
            Console.WriteLine("3) Calcular el factorial de un número.");
            Console.WriteLine("4) Calcular si es número primo.");
            Console.WriteLine("3) Imprimir la serie de Fibonacci.");
            Console.WriteLine("0) Salir.");
        }

        public static void PrintPowerOf2Menu()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("         POTENCIAS EN BASE 2");
            Console.WriteLine("---------------------------------------");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="integerInput">This parameter is the title of the function.</param>
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
        /// 
        /// </summary>
        /// <returns></returns>
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

        public static int ReadUserOption(int minValidInput, int maxValidInput)
        {
            while (true)
            {
                int option = ReadUserOption();
                if (minValidInput <= option && option <= maxValidInput)
                    return option;
                else
                    Console.WriteLine("Valor no válido. Por favor, introduzca un valor entre " + minValidInput + " y " + maxValidInput);
            }
        }

        public static void ExitSubMenu()
        {
            Console.ReadLine();
            //Console.WriteLine("Pulse 'Intro' para continuar...");
            //while (Console.ReadKey().Key != ConsoleKey.Enter)
        }
    }
}
