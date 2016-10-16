/*
    PROGRAMA: MenuSinColores
    AUTOR: Elena Guzman Blanco
    FECHA: 06/Oct/2016
    DESCRIPCION: Este programa muestra sin colores un menu de opciones
*/

using System;

namespace MenuSinColores
{
    class MenuSinColores
    {
        static void Main(string[] args)
        {

            Console.Title = "Menu sin colores";

            // Posiciones fijas del menú
            int col = 10;
            int fila = 5;

            int opcionSeleccionada = 0;

            // Posicionando cursor
            Console.SetCursorPosition(col, fila);

            // Pintando menu
            Console.WriteLine("       Menu principal      ");
            Console.CursorLeft = col;
            Console.WriteLine("   1. Alta                 ");
            Console.CursorLeft = col;
            Console.WriteLine("   2. Baja                 ");
            Console.CursorLeft = col;
            Console.WriteLine("   3. Consulta             ");
            Console.CursorLeft = col;
            Console.WriteLine("   3. Modifica             ");
            Console.CursorLeft = col;
            Console.WriteLine("   Selecciona tu opcion    ");

            // Tomando opciones
            Console.SetCursorPosition(col + 25, fila + 5);
            try
            {
                opcionSeleccionada = int.Parse(Console.ReadLine());
                Console.CursorTop = 1;
                Console.CursorLeft = col;
                Console.WriteLine("Tu opcion es la " + opcionSeleccionada);
            }
            catch
            {
                Console.WriteLine("No es una opcion válida");
            }
            Console.ReadLine();
        }
    }
}
