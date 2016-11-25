/*
    PROGRAMA: LineaCaracteres
    AUTOR: Elena Guzman Blanco
    FECHA: 27/Oct/2016
    DESCRIPCION: Este programa simula un reloj 
*/

using System;

namespace LineaCaracteres
{
	class LineaCaracteres
	{
		public static void Main (string[] args)
		{
			// Variables
			int numVeces = 0;
			ConsoleKeyInfo caracterAEscribir;

			// Titulo de consola
			Console.Title = "Una linea de caracteres...";
			
			Console.WriteLine ("Este programa escribe tantas veces como especifiques un caracter elegido");

			Console.WriteLine ("¿Cuantas veces vas a escribir el caracter?");
			numVeces = ObtenerNum (1, 100);
			Console.WriteLine ("Y ahora, ¿qué caracter quieres escribir?");
			caracterAEscribir = Console.ReadKey ();

			for (int i = 1; i < numVeces; i++) {
				Console.Write (caracterAEscribir.KeyChar);
			}

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
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