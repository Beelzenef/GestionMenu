/*
    PROGRAMA: ExponenciasRecursivas
    AUTOR: Elena Guzman Blanco
    FECHA: 14/Nov/2016
    DESCRIPCION: Este programa calcula potencias de forma recursiva
*/

using System;

namespace ExponenciasRecursivas
{
	class ExponenciasRecursivas
	{
		static void Main(string[] args)
		{
			// Variables
			int numBase = 0;
			int exponencia = 0;
			double resultado = 0;

			// Titulo de consola
			Console.Title = "Exponencias recursivas";

			Console.WriteLine ("Este programa realiza potencias de números de forma recursiva\n\n");
			Console.WriteLine ("¿Qué numero quieres elevar?");
			numBase = ObtenerNum (1, 50);
			Console.WriteLine ("¿Cual será la potencia?");
			exponencia = ObtenerNum (1, 10);
			Console.WriteLine ("\nCalculando...\n");
			resultado = CalcularExponencia(numBase, exponencia);

			checked {
				Console.WriteLine ("{0} elevado a {1} resulta en {2}", numBase, exponencia, resultado);
			}

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();
		}

		static int CalcularExponencia(int nBase, int exp)
		{
			if (nBase == 1 || exp == 0)
				return 1;
			return nBase * CalcularExponencia (nBase, exp - 1);
		}

		static int ObtenerNum(int min, int max)
		{
			bool valido = false;
			int num = 0;

			Console.Write ("Dame un numero... ");

			while (!valido) {
				try {
					num = int.Parse (Console.ReadLine ());
					if (num >= min && num <= max)
						valido = true;
					else
						Console.WriteLine ("Tu numero no es válido, inténtalo otra vez ");
				} catch {
					Console.Write ("Dato no valido, intentalo otra vez ");
				}
			}
			Console.WriteLine ("Tu numero es válido, ¡procede!");
			return num;
		}
	}
}