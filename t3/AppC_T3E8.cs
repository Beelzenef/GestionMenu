/*
    PROGRAMA: NumeroSecreto
    AUTOR: Elena Guzman Blanco
    FECHA: 15/Oct/2016
    DESCRIPCION: Este programa juega a adivinar un numero secreto
*/

using System;

namespace AppC_NumeroSecreto
{
    class AppC_NumeroSecreto
    {
        static void Main(string[] args)
        {
            // Variables
            int nIntentos = 0;
            int numSecreto = 0;
            int numPrueba = 0;
            bool acierto = false;

            // Titulo de consola
            Console.Title = "Adivina el numero secreto";

            // Tomando un numero secreto
            Console.WriteLine("Escribe un número secreto que otro adivinará...");
            Console.WriteLine("¿Cual es tu numero secreto?");
            numSecreto = int.Parse(Console.ReadLine());
            Console.WriteLine("Tenemos el número secreto, ¡a jugar!");
            // Limpiando pantalla
            Console.Clear();
            Console.WriteLine("Hay un número secreto esperando a ser descubierto... \n\n");
            // Bucle hasta encontrar el numero secreto
            while (!acierto)
            {
                Console.WriteLine("¿Cual es tu numero?");
                numPrueba = int.Parse(Console.ReadLine());
                if (numSecreto == numPrueba)
                    acierto = true;
                else
                {
                    Console.WriteLine("¡Fallaste!, inténtalo otra vez");
                    nIntentos++;
                }
            }
            Console.WriteLine("¡Has acertado en {0} intentos!", nIntentos);
            Console.WriteLine();
            // Fin de programa
            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
