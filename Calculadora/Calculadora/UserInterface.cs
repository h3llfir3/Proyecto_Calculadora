
namespace Calculadora
{
    class UserInterface
    {
        // En esta clase aparecerán todos los menús de la aplicación


        // Imprime el menú principal
        public static void PrintMainMenu()
        {
            System.Console.WriteLine("           MENÚ");
            System.Console.WriteLine("----------------------------");
            System.Console.WriteLine("1) Potencias en base 2");
            System.Console.WriteLine("2) Calcular sumatorio");
            System.Console.WriteLine("3) Calcular factorial");
            System.Console.WriteLine("4) Calcular si es número primo");
            System.Console.WriteLine("3) Imprimir la serie de Fibonacci");
            System.Console.WriteLine("0) Salir");
        }

        public static void PrintPowerOf2Menu()
        {
            System.Console.WriteLine("         POTENCIAS EN BASE 2");
            System.Console.WriteLine("---------------------------------------");
        }
    }
}
