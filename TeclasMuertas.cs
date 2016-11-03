using System;
using System.Threading;

namespace TeclasMuertas
{
	class TeclasMuertas
	{
		static void Main(string[] args)
		{
			// Variables
			ConsoleKeyInfo tecla;

			// Titulo de consola
			Console.Title = "Control de teclas de control";
		
			Console.WriteLine ("Pulsa una tecla");
			tecla = Console.ReadKey ();

			if (tecla.Modifiers == (ConsoleModifiers.Alt | ConsoleModifiers.Control))
				Console.WriteLine ("Has pulsado ALT + CTRL");
			if (tecla.Modifiers == (ConsoleModifiers.Alt | ConsoleModifiers.Control | ConsoleModifiers.Shift))
				Console.WriteLine ("Has pulsado ALT + CTRL + SHIFT");
			if (tecla.Modifiers == (ConsoleModifiers)7) {
				Console.WriteLine ("Has pulsado ALT + CTRL + SHIFT");
				if (tecla.Key == ConsoleKey.F11)
					Console.WriteLine ("Y además, has pulsado F11");
			}
			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}

	}
}
