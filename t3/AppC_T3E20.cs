/*
    PROGRAMA: MediaNotas
    AUTOR: Elena Guzman Blanco
    FECHA: 18/Oct/2016
    DESCRIPCION: Este programa calcula una media de notas para los alumnos
*/

using System;

namespace AppC_MediaNotas
{
    class AppC_MediaNotas
    {
        static void Main(string[] args)
        {
            // Variables
            int nNotas = 0;
            int total = 0;
            int num = 0;
            int media = 0;

            // Titulo de consola
            Console.Title = "Calculando la media";

            Console.WriteLine("Este programa calculará la media de notas hasta que introduzcas el valor '0'\n");

            // Tomando numeros
            Console.WriteLine("¿Cual es la primera nota?");
            num = ObtenerNum();

            while (num != 0)
            {
                num = ObtenerNum();
                total += num;
                nNotas++;
                Console.WriteLine("\n¿Siguiente numero?");
            }
            // Calculos finales
            media = total / nNotas;

            Console.WriteLine("\nCalculando notas...");
            Console.WriteLine("La media de las {0} notas es {1}\n", nNotas, media);

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
                    Console.Write("Numero no valido, intentalo otra vez ");
                }
            }
            Console.WriteLine("Tu numero es válido, ¡procede!");
            return num;
        }
    }
}
