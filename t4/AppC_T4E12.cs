/*
   PROGRAMA: FactorialRecursivo
   AUTOR: Elena Guzman Blanco
   FECHA: 9/Nov/2016
   DESCRIPCION: Este programa calcula el factorial de un numero de forma recursiva
*/

using System;

namespace FactorialRecursivo
{
    class FactorialRecursivo
    {
        static void Main(string[] args)
        {
            // Variables
            int num = 0;

            // Titulo de consola
            Console.Title = "Factorial Recursivo";

            Console.WriteLine("Calculando el factorial recursivo de un numero");
            Console.WriteLine("¿Cual es tu número?");
            num = ObtenerNum();
            Console.WriteLine("Calculando...");

            Console.WriteLine("\nEl factorial de {0} es {1}", num, FactRecursivo(num));
            
            // Fin de programa
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }

        static double FactRecursivo(int num)
        {
            if (num == 1 || num == 0)
                return 1;
            return num * FactRecursivo(num - 1);
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
                    Console.Write("Numero no valido, intentalo otra vez ");
                }
            }
            Console.WriteLine("Tu numero es válido, ¡procede!");
            return num;
        }
    }
}