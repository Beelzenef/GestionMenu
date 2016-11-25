
/*
    PROGRAMA: AnioBisiesto
    AUTOR: Elena Guzman Blanco
    FECHA: 27/Oct/2016
    DESCRIPCION: Este programa evalua un año para saber si es bisiesto o no 
*/

using System;

namespace AnioBisiesto
{
	class AnioBisiesto
	{
		public static void Main (string[] args)
		{
			// Variables
			int anio = 0;
			string resultado = string.Empty;

			// Titulo de consola
			Console.Title = "Años bisiestos";

			Console.WriteLine("Este programa evalúa si un año es bisiesto o no \n");

			anio = ObtenerNum (1900, 2100);
			resultado = esBisiesto (anio) ? "es bisiesto." : "no es bisiesto";

			Console.WriteLine ("El año {0} {1}", anio, resultado);

			// Fin de programa
			Console.WriteLine("\n\nPulsa ENTER para salir...");
			Console.ReadLine();
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

		static bool esBisiesto(int anio)
		{
			bool bisiestoONo = false;

			if (anio % 4 == 0) {
				if (anio % 100 == 0) {
					if (anio % 400 == 0) {
						bisiestoONo = true;
					}
					else {
						bisiestoONo = false;
					}
				} else {
					bisiestoONo = true;
				}
			} else {
				bisiestoONo = false;
			}

			return bisiestoONo;
		}
	}
}
