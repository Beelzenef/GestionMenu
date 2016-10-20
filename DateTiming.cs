using System;
using System.Threading;

namespace DateTiming
{
	class DateTiming
	{
		static void Main(string[] args)
		{
			// Variables
			// Para DateTime
			DateTime ahora = DateTime.Now;
			DateTime otraFecha = new DateTime ();
			// Para Random
			double resultado = 0;
			Random dado = new Random ();

			int col = 0;
			int fil = 0;
			char asterisco = '*';

			// Titulo de consola
			Console.Title = "ITS FULL OF STARS";

			// Jugando con DateTime
			Console.WriteLine ("=== Its time to DateTiming! ===\n");
			Console.WriteLine (ahora);
			Console.WriteLine (ahora.DayOfWeek);
			Console.WriteLine (ahora.Day);
			Console.WriteLine (ahora.ToShortDateString());

			Console.WriteLine ("\nQuiero mostrar una fecha en este formato dd-mm*yyyy");
			Console.WriteLine ("{0}-{1}*{2}", ahora.Day, ahora.Month, ahora.Year);

			Console.WriteLine ("\nConvirtiendo fechas desde strings");
			otraFecha = DateTime.Parse ("02/12/2015");
			Console.WriteLine (otraFecha.ToLongDateString());

			// Jugando con Random
			Console.WriteLine ("\n=== Its Random time! ===\n");
			Console.WriteLine ("Dos numeros aleatorios entre 0 y 10: {0} y {1}", dado.Next(11), dado.Next(11));
			resultado = dado.NextDouble ();
			Console.WriteLine ("\nResultado de NextDouble: {0} y truncado hasta límite 100: {1}", resultado, Math.Truncate(resultado * 100));
			Console.WriteLine ("\nGenerando 50 numeros aleatorios entre 5 y 20");
			for (int i = 0; i < 50; i++) {
				resultado = dado.Next (5, 21);
				Console.Write ("{0}\t", resultado);
			}

			Console.WriteLine ("\n\nPulsa ENTER para continuar...");
			Console.WriteLine ("Generacion aleatoria de estrellas... ITS FULL OF STARS");
			Console.ReadLine ();
			Console.Clear ();
			Console.CursorVisible = false;

			for (int i = 0; i < 50; i++) {
				col = dado.Next (80);
				fil = dado.Next (24);
				Thread.Sleep (500);
				Console.SetCursorPosition (col, fil);
				Console.Write (asterisco);
			}

			// Salida
			Console.ReadLine ();
		}
	}
}
