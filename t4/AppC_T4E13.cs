/*
   PROGRAMA: FactorialIterativo
   AUTOR: Elena Guzman Blanco
   FECHA: 9/Nov/2016
   DESCRIPCION: Este programa calcula el factorial de un numero de forma iterativa
*/

using System;

namespace FactorialIterativo
{
    class FactorialIterativo
    {
        static void Main(string[] args)
        {
            // Variables
            int num = 0;

            // Titulo de consola
            Console.Title = "Factorial iterativo";

            Console.WriteLine("Calculando el factorial iterativo de un numero");
            Console.WriteLine("¿Cual es tu número?");
            num = ObtenerNum();
            Console.WriteLine("Calculando...");

            Console.WriteLine("\nEl factorial de {0} es {1}", num, FactIterativo(num));
            
            // Fin de programa
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }

        static double FactIterativo(int num)
        {
            double resultado = 1;

            for (int i = 2; i <= num; i++)
                resultado *= i;

            return resultado;
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