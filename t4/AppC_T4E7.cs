/*
    PROGRAMA: NumeroMaximoYMinimo
    AUTOR: Elena Guzman Blanco
    FECHA: 2/Nov/2016
    DESCRIPCION: Este programa muestra el numero máximo y minimo de los introducidos
*/

using System;

namespace NumeroMaximoYMinimo
{
	class NumeroMaximoYMinimo
	{
		public static void Main (string[] args)
		{
			/// Variables
			int num = 0;
			int minimo = 0;
			int maximo = 0;

			// Titulo de consola
			Console.Title = "Numero máximo y mínimo";

			Console.WriteLine ("Este programa le da un valor absoluto a cualquier numero que elijas");
			Console.WriteLine ("¡Evaluará números hasta que escribas 0!\n");

			// Tomando numeros
			Console.WriteLine ("Introduce el primer número:");

			do {
				num = ObtenerNum(0, 100);
				maximo = Maximo(num, maximo);
				minimo = Minimo(num, minimo);

				Console.WriteLine ("Tu numero es {0}, y hasta ahora el numero máximo es {1} y el minimo {2}\n\n", num, maximo, minimo);

			} while (num != 0);

			Console.WriteLine ("Finalizada la evaluación de números");

			// Fin de programa
			Console.WriteLine ("Pulsa ENTER para salir...");
			Console.ReadLine ();
		}

		static int Maximo(int numero, int numMaximo) {

			int resultado = 0;

			if (numero < numMaximo)
				resultado = numMaximo;
			else
				resultado = numero;
			return resultado;
		}

		static int Minimo(int numero, int numMinimo) {
			
			int resultado = 0;

			if (numero > numMinimo)
				resultado = numMinimo;
			else
				resultado = numero;
			
			return resultado;
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