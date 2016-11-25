/*
   PROGRAMA: sumaNNumerosIterativo
   AUTOR: Elena Guzman Blanco
   FECHA: 15/Nov/2016
   DESCRIPCION: Este programa suma los primeros n numeros de forma iterativa
*/

using System;

namespace sumaNNumerosIterativo
{
    class sumaNNumerosIterativo
    {
        static void Main(string[] args)
        {
            // Variables
            int resultado = 0;
            int nVeces = 0;

            // Titulo de consola
            Console.Title = "Suma de primeros N numeros, modo iterativo";

            Console.WriteLine("Este programa suma los primeros n numeros de forma iterativa");
            Console.WriteLine("¿Cuantas numeros quieres sumar? Hasta 100");
            nVeces = ObtenerNum(0, 100);

            Console.WriteLine("Calculando...");
            resultado = SumarNNumerosIterativo(nVeces);

            Console.WriteLine("La suma de {0} numeros de forma iterativa resulta en {1}", nVeces, resultado);

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();

        }

        static int SumarNNumerosIterativo(int numeros)
        {
            int resultado = 0;

            for (int i = 0; i <= numeros; i++)
                resultado += i;

            return resultado;
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