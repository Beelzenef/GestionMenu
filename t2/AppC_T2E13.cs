/*
    PROGRAMA: MenuConColor
    AUTOR: Elena Guzman Blanco
    FECHA: 06/Oct/2016
    DESCRIPCION: Este programa muestra con colores un meno de opciones
*/

using System;

namespace MenuConColores
{
    class MenuConColores
    {
        static void Main(string[] args)
        {

            Console.Title = "Menu con colores";

            // Constantes para la posicion del cursor
            int col = 10;
            int fila = 5;

            int opcionSeleccionada = 0;

            // Posicionando cursor
            Console.SetCursorPosition(col, fila);

            // Pintando menu
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("       Menu principal      ");
            Console.CursorLeft = col;
            Console.BackgroundColor = ConsoleColor.Red;
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
