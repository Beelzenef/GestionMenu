/*
    PROGRAMA: SimulacionReloj
    AUTOR: Elena Guzman Blanco
    FECHA: 27/Oct/2016
    DESCRIPCION: Este programa simula un reloj 
*/

using System;
using System.Threading;

namespace SimulacionReloj
{
	class SimulacionReloj
	{
		public static void Main (string[] args)
		{
			int maxHoras = 24;
			int maxMinYSecs = 60;
			int posH = 10;
			int posV = 5;

			// Titulo de consola
			Console.Title = "Un reloj";

			// Reloj con bucles FOR
			for (int h = 0; h < maxHoras; h++)
				for (int m = 0; m < maxMinYSecs; m++)
					for (int s = 0; s < maxMinYSecs; s++) {
						Console.CursorVisible = false;
						Console.SetCursorPosition (posH, posV);
						Console.WriteLine ("{0:00}:{1:00}:{2:00}", h, m, s);
						Thread.Sleep (1000);
					}
		}
	}
}