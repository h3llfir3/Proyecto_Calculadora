using System;

namespace Calculadora
{
    class Program
    {
        static void LaunchPowerOf2Menu()
        {
            Console.Clear();
            while (true)
            {
                UserInterface.PrintPowerOf2Menu();
                int number = UserInterface.GetUserIntegerInput("Introduzca el exponente a calcular: ");
                int result = Model.Maths.CalcPowerOf2(number);
                Console.WriteLine("2 elevado a " + number + " es " + result);

            }
        }
        static void LaunchMainMenu()
        {
            while (true)
            {
                UserInterface.PrintMainMenu();
                int option = UserInterface.ReadUserOption(0, 5);
                switch (option)
                {
                  case 1:

                }    

            }
        }

        static void Main(string[] args)
        {
            LaunchMainMenu();
        }
    }
}
