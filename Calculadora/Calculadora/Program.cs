using System;

namespace Calculadora
{
    class Program
    {
        static void LaunchPowerOf2Menu()
        {
                UserInterface.PrintPowerOf2Menu();
                int number = UserInterface.GetUserIntegerInput("Introduzca el exponente a calcular: ");
                Console.WriteLine();
                int result = Model.Maths.CalcPowerOf2(number);
                Console.WriteLine("2 elevado a " + number + " es " + result);
                UserInterface.ExitSubMenu();
                return;
        }

        static void LaunchCalcSumationMenu()
        {
                UserInterface.PrintSummationMenu();
                int number = UserInterface.GetUserIntegerInput("Introduzca el número del cual obtener su sumatorio: ");
                Console.WriteLine();
                int result = Model.Maths.CalcSummation(number);
                Console.WriteLine("El sumatorio de " + number + " es " + result);
                UserInterface.ExitSubMenu();
                return;
        }

        static void LaunchFactorialMenu()
        {
                UserInterface.PrintFactorialMenu();
                int number = UserInterface.GetUserIntegerInput("Introduzca el número del cual obtener su factorial: ");
                Console.WriteLine();
                int result = Model.Maths.CalcFactorial(number);
                Console.WriteLine("El factorial de " + number + " es " + result);
                UserInterface.ExitSubMenu();
                return;
        }

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
        static void LaunchMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadUserOption();
                switch (option)
                {
                    case 1:
                        LaunchPowerOf2Menu();
                        break;
                    case 2:
                        LaunchCalcSumationMenu();
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
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Introduzca un valor válido.");
                        break;

                }    

            }
        }

        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
    }
}
