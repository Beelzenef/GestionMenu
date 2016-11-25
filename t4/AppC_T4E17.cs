/*
    PROGRAMA: ObtenerResto
    AUTOR: Elena Guzman Blanco
    FECHA: 4/Nov/2016
    DESCRIPCION: Este programa calcula el resto de una division
*/

using System;

namespace ObtenerResto
{
	class ObtenerResto
	{
		static void Main(string[] args)
		{
			// Variables
			int dividendo = 0;
			int divisor = 0;
			int resto = 0;

			// Titulo de consola
			Console.Title = "Obteniendo el resto";

			Console.WriteLine ("División para obtener el resto de la operación");

			Console.WriteLine ("¿Cuál es el dividendo?");
			dividendo = ObtenerNum (0, 1000);
			Console.WriteLine ("¿Cual es el divisor?");
			divisor = ObtenerNum (0, 1000);
			Console.WriteLine ("Calculando...");
			try {
				resto = dividendo % divisor;
				Console.WriteLine ("La division entre {0} y {1} tiene como resto {2}", dividendo, divisor, resto);
			} catch {
				Console.WriteLine ("No se ha podido realizar la división...");
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