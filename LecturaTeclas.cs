using System;

namespace LecturaTeclas
{
	class LecturaTeclas
	{
		static void Main(string[] args)
		{
			// Variables
			int tecla = 0;
			ConsoleKeyInfo teclita;

			// Titulo de consola
			Console.Title = "Lectura y control de teclas";

			// Usando Read()
			Console.WriteLine ("Lectura de teclas pulsadas\n");
			Console.Write ("Pulsa una tecla: ");
			tecla = Console.Read ();

			// Pausa necesaria para leer el resto del codigo, combinando Read() + ReadLine():
			Console.ReadLine ();

			Console.WriteLine ("Has pulsado la tecla {0}", tecla);

			// Usando ReadKey()
			Console.WriteLine ("\nLectura de tecla pulsada");
			Console.Write ("Pulsa una tecla: ");
			teclita = Console.ReadKey ();
			Console.WriteLine ("\nDatos sobre la tecla pulsada");
			Console.WriteLine ("           Key: " + teclita.Key);
			Console.WriteLine ("       KeyChar: " + teclita.KeyChar);
			Console.WriteLine ("     Modifiers: " + teclita.Modifiers);
	
			// Usando la enumeracion ConsoleKey
			Console.WriteLine ("\n\nEntramos en un bucle que se ejecutará hasta que pulses ESCAPE");
			Console.WriteLine ("Pulsa ENTER para continuar...");
			Console.ReadLine ();
			Console.Clear ();

			do {
				teclita = Console.ReadKey ();
				Console.WriteLine ("\nDatos sobre la tecla pulsada");
				Console.WriteLine ("           Key: " + teclita.Key);
				Console.WriteLine ("       KeyChar: " + teclita.KeyChar);
				Console.WriteLine ("     Modifiers: " + teclita.Modifiers);
			} while (teclita.Key != ConsoleKey.Escape);

			// Eliminando ECHO a pantalla
			Console.WriteLine ("\n\nEntramos en un bucle que se ejecutará hasta que pulses ESCAPE, sin ECHO");
			Console.WriteLine ("Pulsa ENTER para continuar...");
			Console.ReadLine ();
			Console.Clear ();

			do {
				teclita = Console.ReadKey (true);
				Console.WriteLine ("\nDatos sobre la tecla pulsada");
				Console.WriteLine ("           Key: " + teclita.Key);
				Console.WriteLine ("       KeyChar: " + teclita.KeyChar);
				Console.WriteLine ("     Modifiers: " + teclita.Modifiers);
			} while (teclita.Key != ConsoleKey.Escape);

			// Modificando salida por pantalla
			Console.WriteLine ("\n\nCada pulsacion será una *");
			Console.WriteLine ("Pulsa ENTER para continuar...");
			Console.ReadLine ();
			Console.Clear ();

			do {
				teclita = Console.ReadKey (true);
				Console.Write ("*");
			} while (teclita.Key != ConsoleKey.Escape);

			// Escribiendo hasta pulsar tecla
			Console.WriteLine ("\n\nEscribiendo * hasta pulsar tecla");
			Console.WriteLine ("Pulsa ENTER para continuar...");
			Console.ReadLine ();
			Console.Clear ();

			do {
				teclita = Console.ReadKey (true);
				Console.Write ("*");
			} while (!Console.KeyAvailable);

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}

	}
}
