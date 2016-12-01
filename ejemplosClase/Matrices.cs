using System;

namespace Matrices
{
	class Matrices
	{
		static void Main(string[] args)
		{
			const int NFIL = 5;
			const int NCOL = 5;

			int[,] matriz = new int[NFIL, NCOL];
			int[,] matrizNueva;

			MostrarArray (matriz);
			InicializarAleatorio (matriz);
			MostrarArray (matriz);
			Console.WriteLine ();
			//MostrarArray (CopiarM2D(matriz));
			matrizNueva = CopiarM2D(matriz);
			MostrarArray (matrizNueva);

			#region Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();
			#endregion
		}

		static int[,] CopiarM2D(int[,] origen)
		{
			int filas = origen.GetLength (0);
			int columnas = origen.GetLength (1);

			int[,] nuevaM2D = new int[filas,columnas];

			for (int i = 0; i < filas; i++)
				for (int j = 0; j < columnas; j++)
					nuevaM2D [i, j] = origen[i, j];

			return nuevaM2D;
		}

		static void MostrarArray(int[,] vector2D)
		{
			int filas = vector2D.GetLength (0);
			int columnas = vector2D.GetLength (1);

			for (int i = 0; i < filas; i++) {
				for (int j = 0; j < columnas; j++)
					Console.Write ("{0,2} ", vector2D[i,j]);
				Console.WriteLine ();
			}
		}

		static void InicializarAleatorio(int[,] vector2D)
		{
			int filas = vector2D.GetLength (0);
			int columnas = vector2D.GetLength (1);

			Random dado = new Random ();

			for (int i = 0; i < filas; i++)
				for (int j = 0; j < columnas; j++)
					vector2D [i, j] = dado.Next (100);
		}

		static void InicializarValorInicial(int[,] vector2D, int valorInicial)
		{
			int filas = vector2D.GetLength (0);
			int columnas = vector2D.GetLength (1);

			for (int i = 0; i < filas; i++)
				for (int j = 0; j < columnas; j++)
					vector2D [i, j] = valorInicial;
		}
	}
}