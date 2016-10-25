/*
    PROGRAMA: AMayusculas
    AUTOR: Elena Guzman Blanco
    FECHA: 20/Oct/2016
    DESCRIPCION: Este programa convierte en mayusculas cualquier caracter introducido
*/

using System;

namespace AMayusculas
{
    class AMayusculas
    {
        static void Main(string[] args)
        {
            // Variables
            string stringBase = string.Empty;

            ConsoleKeyInfo tecla;
            char asterisco = '*';

            // Titulo de consola
            Console.Title = "Convirtiendo a mayusculas";

            Console.WriteLine("Este programa convierte en mayúscula cualquier caracter que le pases, hasta introducir asterisco\n");
            Console.WriteLine("Introduce caracteres para empezar a convertir...");

            do {
                tecla = Console.ReadKey(true);
                stringBase = tecla.KeyChar.ToString();
                Console.WriteLine("Tu caracter es {0} y su mayuscula es {1}, ¿siguiente caracter?", tecla.KeyChar, stringBase.ToUpper());
            }
            while (tecla.KeyChar != asterisco);

            // Fin de programa
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }

    }
}