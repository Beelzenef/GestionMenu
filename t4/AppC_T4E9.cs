/*
    PROGRAMA: MediaDeNotas
    AUTOR: Elena Guzman Blanco
    FECHA: 27/Oct/2016
    DESCRIPCION: Este programa calcula la media de notas introducidas
*/

using System;

namespace MediaDeNotas
{
	class MediaDeNotas
	{
		public static void Main (string[] args)
		{
			/// Variables
			int nNotas = 0;
			int total = 0;
			int num = 0;
			int media = 0;

			// Titulo de consola
			Console.Title = "Calculando la media";

			Console.WriteLine ("Este programa calculará la media de notas hasta que introduzcas el valor '0'\n");

			// Tomando numeros
			Console.WriteLine ("¿Cual es la primera nota?");

			do {
				num = ObtenerNum (0,10);
				total += num;
				nNotas++;
				Console.WriteLine ("\n¿Siguiente numero?");
			} while (num != 0);

			// Calculos finales
			media = total / nNotas;

			Console.WriteLine ("\nCalculando notas...");
			Console.WriteLine ("La media de las {0} notas es {1}\n", nNotas, media);

			// Fin de programa
			Console.WriteLine ("Pulsa ENTER para salir...");
			Console.ReadLine ();
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