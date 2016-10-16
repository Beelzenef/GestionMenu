/*
    PROGRAMA: AreaCirculo
    AUTOR: Elena Guzman Blanco
    FECHA: 06/Oct/2016
    DESCRIPCION: Este programa calcula el area de una circunferencia
*/

using System;

namespace AreaCirculo
{
    class AreaCirculo
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculando el area de un circulo";

            // Variables a obtener
            double area = 0;
            double radio = 0;

            Console.WriteLine("Calculando el area de un circulo");
            // Obteniendo el radio
            Console.WriteLine("Necesitaremos el radio de ese circulo, ¿cuál es?");
            try
            {
                radio = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Lo que has introducido no es un número, supondremos que su radio es 1");
                radio = 1;
            }
            // Resultados
            Console.WriteLine("\n\nCalculando...\n\n");
            area = Math.PI * (radio * radio);

            Console.WriteLine("Para tu circulo, su area es {0:F2}", area);
            Console.WriteLine("Pulsa ENTER para salir del programa...");
            Console.ReadLine();
        }
    }
}
