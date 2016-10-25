/*
    PROGRAMA: MillasAMetros
    AUTOR: Elena Guzman Blanco
    FECHA: 18/Oct/2016
    DESCRIPCION: Este programa convierte de millas a metros
*/

using System;

namespace AppC_MillasAMetros
{
    class AppC_MillasAMetros
    {
        static void Main(string[] args)
        {
            // Variables
            int millas = 0;
            const int METROS = 1852;
            int total = 0;

            // Titulo de consola
            Console.Title = "De millas a metros";

            // Tomando numeros

            Console.WriteLine("Este programa convierte tu cantidad de millas en metros");
            Console.WriteLine("¿Cuantos metros quieres convertir?\n");

            millas = ObtenerNum();
            total = millas * METROS;
            Console.WriteLine("Tus {0} millas se han convertido en {1} metros\n", millas, total);

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
