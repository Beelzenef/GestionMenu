using System;

namespace MatricesDentadas
{
	class MatricesDentadas
	{
		static void Main(string[] args)
		{
			int[][] matriz = new int[2][];

			matriz [0] = new int[3]; 
			matriz [1] = new int[4];

			int[][] otraMatriz = new int[2][];

			otraMatriz [0] = new int[3] { 1, 2, 3 }; 
			otraMatriz [1] = new int[4] { 1, 2, 3, 5 };

			char[][] caracteres = new char[2][] {
				new char[3],
				new char[2]
			};

			int[][] numeritos = new int[2][] {
				new int[3] { 1, 2, 3 },
				new int[2] { 23, 25 }
			};

			#region Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();
			#endregion
		}

	}
}