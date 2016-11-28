using System;

namespace InfoArrays
{
	class InfoArrays
	{
		static void Main(string[] args)
		{
			// Variables
			int[] vector = { 1, 2, 5, 6, 7, 8, 11 };
			char[,] vector2D = { { 'a', 'b', 'c' },
								{ 'x', 'y', 'z' },
								{ 'h', 'b', 'o' } };

			// Titulo de consola
			Console.Title = "Informacion de arrays";

			Console.WriteLine ("Informacion de array:");
			InfoArray (vector);
			Console.WriteLine ("Recorriendo array:");
			RecorrerArray (vector);

			Console.WriteLine ("\n\nInformacion de array de dos dimensiones:");
			InfoArray (vector2D);

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}

		static void RecorrerArray(int[] unArray)
		{
			for (int i = 0; i < unArray.Length; i++) {
				Console.Write ("{0} ", unArray [i]);
			}
		}

		static void InfoArray(Array unArray)
		{
			if (unArray is Array) {
				Console.WriteLine ("- - D A T O S  D E  U N  A R R A Y - -");
				Console.WriteLine ("--------------------------------------");
				Console.WriteLine ("Tipo: \t\t\t{0}", unArray.GetType ());
				Console.WriteLine ("¿Es solo lectura? \t{0}", unArray.IsReadOnly);
				Console.WriteLine ("Longitud: \t\t{0}", unArray.Length);
				Console.WriteLine ("Rank: \t\t\t{0}", unArray.Rank);
				Console.WriteLine ("Indice menor: \t\t{0}", unArray.GetLowerBound (0));
				Console.WriteLine ("Tamaño fijo: \t\t{0}", unArray.IsFixedSize);
			}
			
		}
	}
}

