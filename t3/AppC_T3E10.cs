/*
    PROGRAMA: PrimoEntre7y99
    AUTOR: Elena Guzman Blanco
    FECHA: 19/Oct/2016
    DESCRIPCION: Este programa evalúa si un numero entre 7 y 99 es primo
*/

using System;

namespace PrimoEntre7y99
{
    class PrimoEntre7y99
    {
        static void Main(string[] args)
        {
            // Variables
            int numeroEntre7y99 = 0;

            // Titulo de consola
            Console.Title = "Primo entre 7 y 99";
            // Algoritmo para tomar número y evaluar si es primo
            Console.WriteLine("Este programa evalúa si tu número entre 7 y 99 es primo\n");
            Console.WriteLine("¿Cual es tu número?");
            numeroEntre7y99 = ObtenerNum(7, 99);

            if (esPrimo(numeroEntre7y99))
                Console.WriteLine("Es primo");
            else
                Console.WriteLine("No es primo");

            // Fin de programa
            Console.WriteLine("\nPulsa ENTER para salir...");
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
                    Console.Write("Numero no valido, intentalo otra vez ");
                }
            }
            Console.WriteLine("Tu numero es válido, ¡procede!");
            return num;
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

        static bool esPrimo(int num)
        {
            int contador = 0;

            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0)
                    contador++;

                if (contador > 2)
                    return false;
            }
            return true;
        }
    }
}