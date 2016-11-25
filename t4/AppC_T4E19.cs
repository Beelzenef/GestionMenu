/*
    PROGRAMA: ConejosFibonacci
    AUTOR: Elena Guzman Blanco
    FECHA: 14/Nov/2016
    DESCRIPCION: Este programa calcula los conejos de Fibonacci en n meses
*/

using System;

namespace ConejosFibonacci
{
	class ConejosFibonacci
	{
		static void Main(string[] args)
		{
			// Variables
			int nMeses = 0;

			// Titulo de consola
			Console.Title = "Conejos de Fibonacci";

			Console.WriteLine ("Calculando, segun Fibonacci, cuantos conejos en funcion de meses");
			Console.WriteLine ("¿Cuantos meses quieres evaluar? Hasta 30");
			nMeses = ObtenerNum (1, 30);

			try {
			Console.WriteLine ("\nEl resultado para {0} meses son {1} conejos", nMeses, CalcularConejitos(nMeses));
			}
			catch {
				Console.WriteLine ("ERROR");
			}

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();
		}

		static int CalcularConejitos(int meses)
		{
			if (meses == 0 || meses == 1)
				return 1;
			return CalcularConejitos (meses - 1) + CalcularConejitos (meses - 2);
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