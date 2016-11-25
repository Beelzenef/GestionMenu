/*
   PROGRAMA: sumaNNumerosRecursivo
   AUTOR: Elena Guzman Blanco
   FECHA: 15/Nov/2016
   DESCRIPCION: Este programa suma los primeros n numeros de forma recursiva
*/

using System;

namespace sumaNNumerosRecursivo
{
    class sumaNNumerosRecursivo
    {
        static void Main(string[] args)
        {
            // Variables
            int resultado = 0;
            int nVeces = 0;

            // Titulo de consola
            Console.Title = "Suma de primeros N numeros, modo recursivo";

            Console.WriteLine("Este programa suma los primeros n numeros de forma recursiva");
            Console.WriteLine("¿Cuantas numeros quieres sumar? Hasta 100");
            nVeces = ObtenerNum(0, 100);

            Console.WriteLine("Calculando...");
            resultado = SumarNNumerosRecursivo(nVeces);

            Console.WriteLine("La suma de {0} numeros de forma recursiva resulta en {1}", nVeces, resultado);

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();

        }

        static int SumarNNumerosRecursivo(int numeros)
        {
            if (numeros == 1)
                return 1;
            else
                return numeros + SumarNNumerosRecursivo(numeros - 1);
        }

        static int ObtenerNum(int min, int max)
        {
            bool valido = false;
            int num = 0;

            Console.Write("Dame un numero... ");

            while (!valido)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num >= min && num <= max)
                        valido = true;
                    else
                        Console.WriteLine("Tu numero no es válido, inténtalo otra vez ");
                }
                catch
                {
                    Console.Write("Dato no valido, intentalo otra vez ");
                }
            }
            Console.WriteLine("Tu numero es válido, ¡procede!");
            return num;
        }
    }
}