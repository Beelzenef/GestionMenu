using System;
using System.Threading;

namespace Buclecillos
{
	class Buclecillos
	{
		static void Main(string[] args)
		{
			// Variables
			int maxHoras = 24;
			int maxMinYSecs = 60;
			int posH = 10;
			int posV = 5;

			char salida = 'e';
			char tecla = ' ';

			// Titulo de consola
			Console.Title = "Un reloj y otros bucles";

			// Bucles
			Console.WriteLine ("Jugando con bucles...");
			const int NDATOS = 5;
			int[] listaNums = new int[NDATOS];

			for (int i = 0; i < listaNums.Length; i++) {
				listaNums[i] = i + 1;
			}

			Console.WriteLine ("Mostrando listado con FOR");
			for (int i = 0; i < listaNums.Length; i++) {
				Console.Write ("{0}\t", listaNums [i]);
			}

			Console.WriteLine ("\n\nMostrando listado con FOREACH");
			foreach (int item in listaNums) {
				Console.Write ("{0}\t", item);
			}

			Console.WriteLine ("\n\nPulsa teclas hasta pulsar E, que será la salida...");
			do {
				Console.Write ("¿Cual es tu letra? ");
				tecla = char.Parse(Console.ReadLine());
			} while (tecla != salida);
			Console.WriteLine ("\n¡Saliendo del bucle!");

			// Continuacion
			Console.WriteLine ("\n\nY a continuacion, un reloj.");
			Console.WriteLine ("Pulsa ENTER para continuar...");
			Console.ReadLine ();
			Console.Clear ();

			// Reloj con bucles FOR
			for (int h = 0; h < maxHoras; h++)
				for (int m = 0; m < maxMinYSecs; m++)
					for (int s = 0; s < maxMinYSecs; s++) {
						Console.CursorVisible = false;
						Console.SetCursorPosition (posH, posV);
						Console.WriteLine ("{0:00}:{1:00}:{2:00}", h, m, s);
						Thread.Sleep (1000);
					}

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}
	}
}
