/*
    PROGRAMA: DibujarArbolico
    AUTOR: Elena Guzman Blanco
    FECHA: 9/Nov/2016
    DESCRIPCION: Este programa dibuja un arbol de una altura especificada
*/

using System;

namespace DibujarArbolico
{
    class DibujarArbolico
    {
        static void Main(string[] args)
        {
            int alturaArbol = 0;

            // Titulo de consola
            Console.Title = "Dibujando un arbol";

            Console.WriteLine("¿Cual es la altura de tu árbol?");
            alturaArbol = ObtenerNum(3, 100);
            Console.Clear();
            DibujarArbol(alturaArbol);

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();

        }

        static void DibujarArbol(int altura)
        {
            int posicion = 0;
            for (int i = 1; i <= altura; i++)
            {
                Console.SetCursorPosition(40 - i, i);
                for (int j = 1; j <= (i * 3) - 1; j += 2)
                {
                    Console.Write("*");
                }
                if (i > 1 && i % 2 != 0)
                {
                    Console.Write("*");
                }
            }
            DibujarTronco();
        }

        static void DibujarTronco()
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.CursorLeft = 0 + j;
                }
                Console.Write("*");
            }
        }

        static int ObtenerNum(int min, int max)
        {
            bool valido = false;
            int num = 0;

            Console.Write("Dame un numero... ");

            while (!valido)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num >= min && num <= max)
                        valido = true;
                    else
                        Console.WriteLine("Tu numero no es válido, inténtalo otra vez ");
                }
                catch
                {
                    Console.Write("Dato no valido, intentalo otra vez ");
                }
            }
            Console.WriteLine("Tu numero es válido, ¡procede!");
            return num;
        }
    }
}