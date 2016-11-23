using System;

namespace opArrays
{
	public class opArrays
	{
		static void Main(string[] args)
		{
			// Variables
			const int longitud = 10;

			// Sintaxis general para arrays:
			// tipo[] nombre;

			int[] numeros;
			int[] cincoNumeros = new int[5];
			char[] letritas = { 'a', 'e', 'i' };
			string[] textos = { "C#", "Python", "Ruby", "Javascript", "SASS" };

			// Titulo de la consola
			Console.Title = "Operando arrays";

			// Operando
			// numeros[0] = 10; <- Esta operacion no es posible porque no tiene memoria

			numeros = new int[longitud];

			// Construyendo un array de dos dimensiones
			int[,] filasYcolumnas;

			// Recorriendo arrays
			Console.WriteLine ("\nRecorriendo array mediante un bucle FOR:");
			OperarArrays.MostrarArrayFOR (textos);
			Console.WriteLine ("\nRecorriendo array mediante un bucle FOREACH:");
			OperarArrays.MostrarArrayFOREACH (textos);

			Console.WriteLine ("\nInicializando array de ints...");
			OperarArrays.InicializarArray (cincoNumeros);
			Console.WriteLine ("... y mostrando:");
			OperarArrays.MostrarArrayFOR (cincoNumeros);

			Console.WriteLine ("\nInicializando array de ints aleatoriamente...");
			OperarArrays.InicializarArray (cincoNumeros, 10);
			Console.WriteLine ("... y mostrando:");
			OperarArrays.MostrarArrayFOR (cincoNumeros);
			Console.WriteLine ("Mostrando un array circular");
			OperarArrays.MostrarArrayCircular (cincoNumeros);
			Console.WriteLine ("Mostrando un subarray de forma circular");
			OperarArrays.MostrarSubArrayCircular ();

			// Salida
			Console.WriteLine ("\nPulsa ENTER para salir...");
			Console.ReadLine ();
		}

	}

	public class OperarArrays {

		public static void InicializarArray(int[] numericos)
		{
			int valorInicial = -1;

			for (int i = 0; i < numericos.Length; i++)
				numericos [i] = valorInicial;
		}

		public static void InicializarArray(int[] numericos, int maximoValor)
		{
			Random dado = new Random ();

			for (int i = 0; i < numericos.Length; i++) 
				numericos [i] = dado.Next(maximoValor + 1);
		}

		public static void MostrarArrayCircular(int[] numericos)
		{
			int maximo = 20;
			int posicion = 0;

			for (int i = 0; i < maximo; i++) {
				posicion = i % numericos.Length;
				Console.WriteLine ("{0} -> {1}\t", i, numericos [posicion]);
			}
		}

		public static void MostrarSubArrayCircular()
		{
			int[] numerosParaSubarray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			int maximo = 20;
			int posicion = 0;
			// Vueltas entre valores 3, 4 y 5
			int posInicial = 2;
			int posFinal = 4;

			int lengthSubarray = posFinal - posInicial + 1;

			for (int i = 0; i <= maximo; i++) {
				posicion = (i % lengthSubarray) + posInicial;
				Console.WriteLine ("Para {0,2} >> {1}\t", i, numerosParaSubarray [posicion]);
			}
		}

		public static void MostrarArrayFOR(int[] numericos)
		{
			for (int i = 0; i < numericos.Length; i++)
				Console.WriteLine ("\t" + numericos[i]);
		}

		public static void MostrarArrayFOR(string[] listaPalabros)
		{
			for (int i = 0; i < listaPalabros.Length; i++)
				Console.WriteLine ("\t" + listaPalabros[i]);
		}

		public static void MostrarArrayFOREACH(string[] listaPalabros)
		{
			foreach (var item in listaPalabros)
				Console.WriteLine ("\t" + item);
		}
	}
}

