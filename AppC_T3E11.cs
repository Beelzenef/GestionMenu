/*
    PROGRAMA: CuadradoParesMediaImpares
    AUTOR: Elena Guzman Blanco
    FECHA: 17/Oct/2016
    DESCRIPCION: Este programa sumará los pares y mostrará su cuadrado, y sumará los impares para mostrar su media
*/

using System;

namespace AppC_T3E11
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Variables
			int num = 0;
			int sumaPares = 0;
			double cuadradoPares = 0;
			int sumaImpares = 0;
			int mediaImpares = 0;
			int contImpares = 0;

			// Proceso
			Console.Title = "Suma de numeros pares e impares";
			Console.WriteLine ("Este programa leerá números hasta que introduzcas 0...");
			Console.WriteLine ("Sumará los pares y mostrará su cuadrado,\n y sumará los impares para mostrar su media");

			Console.WriteLine ("\n\n ¿Empezamos? \nEsperando un numero...");
			try {
				num = int.Parse (Console.ReadLine ());
			}
			catch {
				Console.WriteLine ("Suponiendo que tu numero es 1...");
				num = 1;
			}
			// Bucle de lectura
			while (num != 0) {

				// Evaluando si par o impar
				if (num % 2 == 0)
					sumaPares += num;
				else {
					sumaImpares += num;
					contImpares++;
				}
				// Leyendo nuevo numero...
				Console.WriteLine ("¡Siguiente numero!");

				try {
					num = int.Parse (Console.ReadLine ());
				}
				catch {
					Console.WriteLine ("Suponiendo que tu numero es 1...");
					num = 1;
				}
			}

			// Operaciones finales
			mediaImpares = sumaImpares / contImpares;
			cuadradoPares = Math.Pow(sumaPares, 2);
			Console.WriteLine ("Mostrando resultados...");
			Console.WriteLine ("Suma y cuadrado de pares: {0}", cuadradoPares);
			Console.WriteLine ("Suma y media de impares: {0}", mediaImpares);

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();
		}
	}
}
