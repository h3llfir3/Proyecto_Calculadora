using System;

namespace Calculadora
{
    class Program
    {
        /// <summary>
        /// The method LaunchePowerof2Menu prints the power of 2 menu, 
        /// reads user input, calls CalcPowerOf2, prints the result and exits the menu.
        /// </summary>
        static void LaunchPowerOf2Menu()
        {
                UserInterface.PrintPowerOf2Menu();
                int number = UserInterface.GetUserIntegerInput("Introduzca el exponente a calcular: ");
                Console.WriteLine();
                int result = Model.Maths.CalcPowerOf2(number);
                Console.WriteLine("2 elevado a " + number + " es " + result + ".");
                UserInterface.ExitSubMenu();
                return;
        }

        /// <summary>
        /// The method LaunchSummationMenu prints the summatory menu,
        /// reads user input, calls CalcSummatory, prints the result and exits the menu.
        /// </summary>
        static void LaunchCalcSummatoryMenu()
        {
                UserInterface.PrintSummatoryMenu();
                int number = UserInterface.GetUserIntegerInput("Introduzca el número del cual obtener su sumatorio: ");
                Console.WriteLine();
                int result = Model.Maths.CalcSummatory(number);
                Console.WriteLine("El sumatorio de " + number + " es " + result + ".");
                UserInterface.ExitSubMenu();
                return;
        }

        /// <summary>
        /// The method LaunchFactorial prints the factorial menu,
        /// reads user input, calls CalcFactorial, prints the result and exits the menu.
        /// </summary>
        static void LaunchFactorialMenu()
        {
                UserInterface.PrintFactorialMenu();
                int number = UserInterface.GetUserIntegerInput("Introduzca el número del cual obtener su factorial: ");
                Console.WriteLine();
                int result = Model.Maths.CalcFactorial(number);
                Console.WriteLine("El factorial de " + number + " es " + result + ".");
                UserInterface.ExitSubMenu();
                return;
        }

        /// <summary>
        /// The method LaunchPrimeMenu prints the prime number menu,
        /// gets user input, calls IsPrime, prints the result and exits the menu.
        /// </summary>
        static void LaunchPrimeMenu()
        {
                UserInterface.PrintPrimeMenu();
                int number = UserInterface.GetUserIntegerInput("Introduzca el número a comprobar: ");
                Console.WriteLine();
                bool result = Model.Maths.IsPrime(number);
                if (result == true)
                    Console.WriteLine("El número " + number + " es primo.");
                else
                    Console.WriteLine("El número " + number + " no es primo.");
                UserInterface.ExitSubMenu();
                return;
        }

        /// <summary>
        /// The method LaunchFibonacciMenu prints the fibonacci sequence menu,
        /// gets user input, calls PrintFibonacci, prints the result and exits the menu.
        /// </summary>
        static void LaunchFibonacciMenu()
        {
                UserInterface.PrintFibonacciMenu();
                int number = UserInterface.GetUserIntegerInput("Introduzca la cantidad de números que desee mostrar: ");
                Console.WriteLine();
                Console.Write(Model.Maths.PrintFibonacci(number));
                Console.WriteLine();
                UserInterface.ExitSubMenu();
                return;            
        }

        /// <summary>
        /// The method LaunchMainMenu calls PrintMainMenu, asks for user input (0-5) through the ReadUserInput method,
        /// and depending on the input it launches another menu, or closes the program (in case 0).
        /// </summary>
        static void LaunchMainMenu()
        {
            bool exit = false;
            while (exit == false)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadUserOption();
                switch (option)
                {
                    case 1:
                        LaunchPowerOf2Menu();
                        break;
                    case 2:
                        LaunchCalcSummatoryMenu();
                        break;
                    case 3:
                        LaunchFactorialMenu();
                        break;
                    case 4:
                        LaunchPrimeMenu();
                        break;
                    case 5:
                        LaunchFibonacciMenu();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Introduzca un valor válido.");
                        break;

                }    

            }
        }

        /// <summary>
        /// Main calls the LaunchMainMenu.
        /// </summary>
        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
    }
}
