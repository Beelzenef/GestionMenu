/*
    PROGRAMA: ValorAbsoluto
    AUTOR: Elena Guzman Blanco
    FECHA: 27/Oct/2016
    DESCRIPCION: Este programa muestra el valor absoluto de un numero entre -1000 y 1000
*/

using System;

namespace ValorAbsoluto
{
	class ValorAbsoluto
	{
		public static void Main (string[] args)
		{
			/// Variables
			int num = 0;
			int numAbsoluto = 0;

			// Titulo de consola
			Console.Title = "Calculando la media";

			Console.WriteLine ("Este programa le da un valor absoluto a cualquier numero que elijas\n");

			// Tomando numeros
			Console.WriteLine ("¿Cual es el numero que deseas convertir");
			num = ObtenerNum (-1000, 1000);

			numAbsoluto = Math.Abs (num);

			Console.WriteLine ("Tu numero {0} tiene como valor absoluto: {1}", num, numAbsoluto);

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