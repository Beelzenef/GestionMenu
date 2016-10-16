/*
    PROGRAMA: CalculoCilindro
    AUTOR: Elena Guzman Blanco
    FECHA: 06/Oct/2016
    DESCRIPCION: Este programa calcula el area lateral y el volumen de un cilindro
*/

using System;

namespace CalculoCilindro
{
    class CalculoCilindro
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculando con un cilindro";

            // Variables a conseguir
            double volumen = 0;
            double radio = 0;
            double altura = 0;
            double areaLateral = 0;

            Console.WriteLine("Calculando el volumen y el área lateral de un cilindro");
            // Obteniendo el radio
            Console.WriteLine("Necesitaremos el radio de ese cilindro, ¿cuál es?");
            try
            {
                radio = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Lo que has introducido no es un número, supondremos que su radio es 1");
                radio = 1;
            }
            // Obteniendo la altura
            Console.WriteLine("También necesitaremos su altura, ¿cuál es?");
            try
            {
                altura = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Lo que has introducido no es un número, supondremos que su altura es 1");
                radio = 1;
            }
            // Resultados
            Console.WriteLine("\n\nCalculando...\n\n");
            volumen = Math.PI * (radio * radio) * altura;
            areaLateral = 2 * Math.PI * radio * altura;

            Console.WriteLine("Para tu cilindro, su area lateral es {0:F2} y su volumen es {1:F2}", areaLateral, volumen);
            Console.WriteLine("Pulsa ENTER para salir del programa...");
            Console.ReadLine();
        }
    }
}
