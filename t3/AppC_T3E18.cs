/*
    PROGRAMA: CalculoCilindro
    AUTOR: Elena Guzman Blanco
    FECHA: 18/Oct/2016
    DESCRIPCION: Este programa calcula el area lateral y el volumen de un cilindro
*/

using System;

namespace CalculoCilindro
{
    class CalculoCilindro
    {
        static void Main(string[] args)
        { 
            // Variables a conseguir
            double volumen = 0;
            double radio = 0;
            double altura = 0;
            double areaLateral = 0;

            // Titulo de consola
            Console.Title = "Calculando con un cilindro";

            Console.WriteLine("Calculando el volumen y el área lateral de un cilindro");
            // Obteniendo el radio
            Console.WriteLine("Necesitaremos el radio de ese cilindro, ¿cuál es?");
            radio = ObtenerNum();

            // Obteniendo la altura
            Console.WriteLine("También necesitaremos su altura, ¿cuál es?");
            altura = ObtenerNum();
            // Resultados
            Console.WriteLine("\n\nCalculando...\n\n");
            volumen = Math.PI * (radio * radio) * altura;
            areaLateral = 2 * Math.PI * radio * altura;

            Console.WriteLine("Para tu cilindro, su area lateral es {0:F2} y su volumen es {1:F2}", areaLateral, volumen);
            Console.WriteLine("Pulsa ENTER para salir del programa...");
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
                    Console.Write("Numero no valido, intentalo otra vez");
                }
            }
            Console.WriteLine("Tu numero es válido, ¡procede!");
            return num;
        }
    }
}