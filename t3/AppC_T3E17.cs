/*
    PROGRAMA: ComparandoTresNums
    AUTOR: Elena Guzman Blanco
    FECHA: 18/Oct/2016
    DESCRIPCION: Este programa compara tres numeros
*/

using System;

namespace AppC_ComparandoTresNums
{
    class AppC_ComparandoTresNums
    {
        static void Main(string[] args)
        {
            // Variables
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            bool igualdadEncontrada = false;

            // Titulo de consola
            Console.Title = "Comparando tres numeros";

            Console.WriteLine("Comparando tres numeros, ¿es la suma de dos de ellos resultante en el tercero?\n\n");
            // Tomando numeros
            Console.WriteLine("¿Cual es tu primer numero?");
            num1 = ObtenerNum();
            Console.WriteLine("¿Cual es tu segundo numero?");
            num2 = ObtenerNum();
            Console.WriteLine("Cual es tu tercer numero?");
            num3 = ObtenerNum();

            Console.WriteLine("\n\nCalculando...\n");

            if (num1 + num2 == num3)
                igualdadEncontrada = true;
            if (num2 + num3 == num2)
                igualdadEncontrada = true;
            if (num2 + num3 == num1)
                igualdadEncontrada = true;

            if (igualdadEncontrada)
                Console.WriteLine("IGUALES");
            else
                Console.WriteLine("DIFERENTES");

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
