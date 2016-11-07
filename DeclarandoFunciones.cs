using System;

namespace DeclarandoFunciones
{
	class DeclarandoFunciones
	{
		static void Main(string[] args)
		{
			// Variables
			int numero = 0;

			// Titulo de consola
			Console.Title = "Funciones, recursion e iteracion";

			Console.WriteLine ("Este programa convierte un numero a su valor absoluto");
			Console.WriteLine ("¿Qué número quieres convertir?");
			try {
				numero = int.Parse (Console.ReadLine ());
			}
			catch {
				Console.WriteLine ("Numero no valido");
			}

			// Comparando metodo propio con metodo de Clase Math
			Console.WriteLine ("El numero es {0} y su absoluto con funcion propia es {1}", numero, Absoluto (numero));
			Console.WriteLine ("El numero es {0} y su absoluto con Math.Abs() es {1}", numero, Math.Abs(numero));
			Console.WriteLine ();

			// Invocando metodos para escribir por pantalla
			EscribirUnCaracter(7, '*');
			Console.WriteLine ();
			EscribirUnCaracter(7, '*', ConsoleColor.Red);
			Console.WriteLine ();
			EscribirUnCaracter (10, '+', 10, 10);
			Console.WriteLine ("\n\nBucle infinito hasta pulsar una tecla, ¿preparado? Pulsa ENTER para proceder");
			Console.ReadLine ();
			EscribirUnCaracter ('*');

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}

		#region Mis metodos, MI TESORO

		/// <summary>
		/// Devuelve el valor absoluto de un número
		/// </summary>
		/// <param name="num">El valor a convertir en su valor absoluto</param>
		/// <returns>Devuelve el valor absoluto del numero especificado</returns>
		static int Absoluto(int num)
		{
			if (num < 0)
				return num * -1;
			return num;
		}

		/// <summary>
		/// Muestra un caracter tantas veces como se especifique como un entero
		/// </summary>
		/// <param name="nVeces">Numero de veces a escribir el caracter</param>
		/// <param name="caracterAEscribir">Caracter a escribir</param>
		private static void EscribirUnCaracter(int nVeces, char caracterAEscribir)
		{
			for (int i = 0; i < nVeces; i++)
				Console.Write (caracterAEscribir);
		}

		/// <summary>
		/// Muestra un caracter tantas veces como se especifique como un entero
		/// </summary>
		/// <param name="nVeces">Numero de veces a escribir el caracter</param>
		/// <param name="caracterAEscribir">Caracter a escribir</param>
		/// <param name="posX">Posicion X de consola</param>
		/// <param name="posY">Posicion Y de consola</param>
		private static void EscribirUnCaracter(int nVeces, char caracterAEscribir, int posX, int posY)
		{
			// Controlando limites de consola
			if (posX > Console.LargestWindowWidth || posY > Console.LargestWindowHeight)
				return;
			
			Console.SetCursorPosition (posX, posY);
			for (int i = 0; i < nVeces; i++)
				Console.Write (caracterAEscribir);
		}

		/// <summary>
		/// Muestra un caracter tantas veces como se especifique como un entero
		/// </summary>
		/// <param name="nVeces">Numero de veces a escribir el caracter</param>
		/// <param name="caracterAEscribir">Caracter a escribir</param>
		/// <param name="colorAEscribir">Color de consola con el que escribir el caracter</param>
		private static void EscribirUnCaracter(int nVeces, char caracterAEscribir, ConsoleColor colorAEscribir)
		{
			// Varibles
			ConsoleColor colorEntrada = Console.ForegroundColor;

			// Escribiendo el caracter a color elegido
			Console.ForegroundColor = colorAEscribir;
			for (int i = 0; i < nVeces; i++)
				Console.Write (caracterAEscribir);
			Console.ForegroundColor = colorEntrada;
		}

		/// <summary>
		/// Muestra un caracter tantas veces como pueda hasta que se pulse una tecla cualquiera
		/// </summary>
		/// <param name="caracterAEscribir">Caracter a escribir</param>
		private static void EscribirUnCaracter (char caracterAEscribir)
		{
			do {
				Console.Write (caracterAEscribir);
			} while (!Console.KeyAvailable);
		}



		#endregion

	}
}
