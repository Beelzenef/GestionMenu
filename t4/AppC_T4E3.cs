/*
   PROGRAMA: BucleDePrimos
   AUTOR: Elena Guzman Blanco
   FECHA: 3/Nov/2016
   DESCRIPCION: Este programa evalua numeros primos hasta introducir 0
*/

using System;

namespace BucleDePrimos
{
    class BucleDePrimos
    {
        static void Main(string[] args)
        {
            // Variables
            int num = 1;

            // Titulo de consola
            Console.Title = "BucleDePrimos";

            Console.WriteLine("Evalua números para saber si son primos");
            Console.WriteLine("Si introduces 0, ¡saldrás del programa!\n\n");

            do
            {
                Console.WriteLine("\n\n¿Cual es tu numero?");
                num = ObtenerNum(0, 100);
                
                if (esPrimo(num))
                    Console.WriteLine("Tu numero es primo");
                else
                    Console.WriteLine("Tu numero no es primo");

            } while (num != 0);

            Console.WriteLine("Saliendo del programa");
            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();

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