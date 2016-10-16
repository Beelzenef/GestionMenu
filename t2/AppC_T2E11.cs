/*
    PROGRAMA: Saludo
    AUTOR: Elena Guzman Blanco
    FECHA: 06/Oct/2016
    DESCRIPCION: Este programa saluda al usuario después de conocer su nombre
*/

using System;

namespace AppC_Saludo
{
    class AppC_Saludo
    {
        static void Main(string[] args)
        {

            Console.Title = "Saludando al usuario";

            // Declaracion de variables
            string nombre = string.Empty;
            // Pidiendo nombre
            Console.WriteLine("Este programa te saluda, ¿cuál es tu nombre?");
            nombre = Console.ReadLine();
            Console.WriteLine("Bienvenidx al universo .NET, " + nombre);
            Console.WriteLine("Pulsa ENTER para salir del programa");
            Console.ReadLine();
        }
    }
}
