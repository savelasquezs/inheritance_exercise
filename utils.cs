using System;


namespace MainProgram
{
    class Utils
    {

        public static void showTitle(string title)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            System.Console.WriteLine($"\n {title}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int GetindexOfIterable(int[] numbers)
        {
            int index;
            Console.WriteLine($"Ingrese un indice entre 0 y {numbers.Length - 1}:");
            while (!int.TryParse(Console.ReadLine(), out index) || index < 0 || index >= numbers.Length)
            {

                if (index < 0 || index >= numbers.Length)
                {
                    Console.Clear();
                    showError($"El indice debe ser un numero entre 0 y {numbers.Length - 1}");
                }
                showError("Ingrese por favor un indice valido del elemento: ");


            } ;
            clearWindow();
            return index;

        }

        public static int validateNumericalOption(int[] arrayOfOptions)
        {
            int number;
            Console.WriteLine("Por favor ingrese el numero de su elección");
            while (!int.TryParse(Console.ReadLine(), out number) || number < arrayOfOptions.Min() || number > arrayOfOptions.Max())
            {
                showError("Por favor ingrese una opción valida: ");

            }
            clearWindow();
            return number;
        }

        public static void showError(string message)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine($"\n {message}\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void clearWindow()
        {
            Console.Clear();
        }

        public static int ValidateInteger(string message = "Ingrese un numero entero: ")
        {
            int number = 0;
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write($"{message}\n");
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    isValidInput = true;
                }
                else
                {
                    showError("Error: Debe ingresar un numero entero.");
                }
            }
            return number;
        }


        public static float ValidateFloat(string message = "Ingrese un numero real: ")
        {
            float number = 0;
            bool isValidInput = false;
            while (!isValidInput)
            {
                Console.Write($"{message}\n");
                if (float.TryParse(Console.ReadLine(), out number))
                {
                    isValidInput = true;
                }
                else
                {
                    showError("Error: Debe ingresar un numero real.");
                }
            }

            return number;

        }
    }

}
