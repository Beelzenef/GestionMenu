/*
    PROGRAMA: Quinielilla
    AUTOR: Elena Guzman Blanco
    FECHA: 17/Oct/2016
    DESCRIPCION: Este programa muestra 15 resultados aleatorios simulando una quiniela
*/

using System;

namespace AppC_T3E21
{
	class AppC_T3E21
	{
		public static void Main (string[] args)
		{
			// Variables
			int sumaX = 0;
			int suma1 = 0;
			int suma2 = 0;
			int resultado = 0;
			char casilla = ' ';

			Random dadico = new Random ();

			Console.WriteLine ("Mostrando los resultados de una quiniela...\n");

			for (int i = 0; i < 15; i++) {
				resultado = dadico.Next (0, 3);

				switch (resultado) {
				case 0:
					casilla = '1';
					suma1++;
					break;
				case 1:
					casilla = 'X';
					sumaX++;
					break;
				case 2:
					casilla = '2';
					suma2++;
					break;
				}

				Console.WriteLine ("\t\t\t\t{0}", casilla);
			}

			// Resultados finales
			Console.WriteLine ("Resultados:");
			Console.WriteLine ("\t Para 1, {0} resultados", suma1);
			Console.WriteLine ("\t Para X, {0} resultados", sumaX);
			Console.WriteLine ("\t Para 2, {0} resultados", suma2);

			//Salida
			Console.WriteLine("\n\nPulsa ENTER para salir del programa");
			Console.ReadLine();
		}
	}
}
