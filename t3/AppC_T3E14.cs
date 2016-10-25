/*
    PROGRAMA: FormatoVars
    AUTOR: Elena Guzman Blanco
    FECHA: 19/Oct/2016
    DESCRIPCION: Este programa formatea la salida de diversas variables
*/

using System;

namespace FormatoVars
{
    class FormatoVars
    {
        static void Main(string[] args)
        {
            // Variables
            double dosYMedio = 2.5;
            double menosDosYMedio = -2.5;
            int veinticinco = 25;
            int doscincuenta = 250;
            int dosMillones5 = 2500000;

            // Titulo de consola
            Console.Title = "Formateando variables";

            Console.WriteLine("Este programa formatea la salida por pantalla de varios numeros\n");

            Console.WriteLine("{0:D5}", veinticinco);
            Console.WriteLine("{0:E}", dosMillones5);
            Console.WriteLine("{0:F2}", veinticinco);
            Console.WriteLine("{0}", veinticinco);
            Console.WriteLine("{0}", dosYMedio);
            Console.WriteLine("{0:N}", dosMillones5);
            Console.WriteLine("{0:X}", doscincuenta);

            // Fin de programa
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }

    }
}