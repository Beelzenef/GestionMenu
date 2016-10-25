/*
    PROGRAMA: ComparandoDosNums
    AUTOR: Elena Guzman Blanco
    FECHA: 18/Oct/2016
    DESCRIPCION: Este programa compara dos numeros
*/

using System;

namespace AppC_ComparandoDosNums
{
    class AppC_ComparandoDosNums
    {
        static void Main(string[] args)
        {
            // Variables
            int numX = 0;
            int numY = 0;

            // Titulo de consola
            Console.Title = "Comparando dos numeros";

            // Tomando numeros
            Console.WriteLine("Este programa compara dos numeros\n\n");
            Console.WriteLine("¿Cual es el primer numero?");

            numX = ObtenerNum();
            Console.WriteLine("¿Cual es el segundo numero?");
            numY = ObtenerNum();

            // Comparando...
            Console.WriteLine("\nComparando...\n");

            if (numX > numY)
                Console.WriteLine("El primer numero es mayor que el segundo");
            else
                Console.WriteLine("El primer numero es menor que el segundo");

            // Fin de programa
            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }

        static int ObtenerNum()
        {
            bool valido = false;
            int num = 0;

            Console.Write("Dame un numero... ");

            while (!valido)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    valido = true;  
                }
                catch
                {
                    Console.Write("Numero no valido, intentalo otra vez");
                }
            }
            Console.WriteLine("Tu numero es válido, ¡procede!");
            return num;
        }
    }
}
