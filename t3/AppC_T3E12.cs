/*
    PROGRAMA: PrimoHasta1000
    AUTOR: Elena Guzman Blanco
    FECHA: 19/Oct/2016
    DESCRIPCION: Este programa toma un numero hasta 1000 y imprime todos los primos anteriores a el
*/

using System;

namespace PrimoHasta1000
{
    class PrimoHasta1000
    {
        static void Main(string[] args)
        {
            // Variables
            int primoHasta1000 = 0;

            // Titulo de consola
            Console.Title = "Primo hasta 1000";
            // Algoritmo para tomar número y evaluar si es primo
            Console.WriteLine("Este programa imprime todos los números primos desde 0 a tu numero con límite 1000\n");
            Console.WriteLine("¿Cual es tu número?");
            primoHasta1000 = ObtenerNum(0, 1000);

            Console.WriteLine("\n\n¡Comenzamos!\n");
            for (int i = 1; i <= primoHasta1000; i++)
            {
                if (esPrimo(i))
                    Console.Write("{0} ", i);
            }

            // Fin de programa
            Console.WriteLine("\n\nPulsa ENTER para salir...");
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