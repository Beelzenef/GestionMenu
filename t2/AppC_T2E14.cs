/*
    PROGRAMA: AreaTriangulo
    AUTOR: Elena Guzman Blanco
    FECHA: 06/Oct/2016
    DESCRIPCION: Este programa calcula el area de un triangulo
*/

using System;

namespace AreaTriangulo
{
    class AreaTriangulo
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculando el area de un triangulo";

            // Variables a rellenar para calculos
            double area = 0;
            double baseT = 0;
            double altura = 0;

            Console.WriteLine("Calculando el area de un triangulo");
            // Obteniendo la base del triangulo
            Console.WriteLine("Necesitaremos la base de ese triangulo, ¿cuál es?");
            try
            {
                baseT = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Lo que has introducido no es un número, supondremos que su base es 1");
                baseT = 1;
            }
            // Obteniendo la altura del triangulo
            Console.WriteLine("Necesitaremos la altura de ese triangulo, ¿cuál es?");
            try
            {
                altura = double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Lo que has introducido no es un número, supondremos que su altura es 1");
                altura = 1;
            }

            // Resultados
            Console.WriteLine("\n\nCalculando...\n\n");
            area = (baseT * altura) / 2;

            Console.WriteLine("Para tu triangulo, su area es {0:F2}", area);
            Console.WriteLine("Pulsa ENTER para salir del programa...");
            Console.ReadLine();
        }
    }
}
