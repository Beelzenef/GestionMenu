using System;

namespace menu
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int col = 20;
			int fila = 8;

			int opcionSeleccionada = 0;

			// Posicionando cursor
			Console.SetCursorPosition(col, fila);

			// Pintando menu
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine ("       Menu principal      ");
			Console.CursorLeft = col;
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine ("   1. Opcion 1             ");
			Console.CursorLeft = col;
			Console.WriteLine ("   2. Opcion 2             ");
			Console.CursorLeft = col;
			Console.WriteLine ("   3. Opcion 3             ");
			Console.CursorLeft = col;
			Console.WriteLine ("   Selecciona tu opcion    ");

			// Tomando opciones
			Console.SetCursorPosition (45, 12);
			try {
				opcionSeleccionada = int.Parse(Console.ReadLine());
				Console.CursorTop = 1;
				Console.CursorLeft = col;
				Console.WriteLine ("Tu opcion es la " + opcionSeleccionada);
			} catch {
				Console.WriteLine ("No es una opcion válida");
			}
		
			Console.CursorVisible = false;
			Console.ReadLine ();
		}
	}
}
