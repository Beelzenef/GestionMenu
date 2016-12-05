using System;

namespace MatricesEscalonadas
{
	class MatricesEscalonadas
	{
		static void InicializarAleatoria(int[][] m)
		{
			Random dado = new Random ();

			int minimo = 10;
			int maximo = 99;

			int d0 = m.Length;

			for (int i = 0; i < d0; i++)
				for (int j = 0; j < m[i].Length; j++)
					m [i] [j] = dado.Next(minimo, maximo + 1);
		}

		static void MostrarMEscalonada(int[][] m)
		{
			int d0 = m.Length;
			int d00 = m [0].Length;
			int d01 = m [1].Length;

			for (int i = 0; i < d0; i++) {
				Console.Write ("M[{0}] ", i);
					for (int j = 0; j < m[i].Length; j++)
						Console.Write ("{0,2} ", m [i] [j]);
					Console.WriteLine ();
			}
			Console.WriteLine ("\nNo hay más datos que mostrar...\n");
		}

		static int[][] CrearMEscalonada(int nDimensiones, int[] longNuevosArrays)
		{
			int[][] m = new int[nDimensiones][];

			for (int i = 0; i < nDimensiones; i++)
					m[i] = new int[longNuevosArrays[i]];

			return m;
		}
		
		
		static void MostrarVector(int[] v)
		{
			for (int i = 0; i < v.Length; i++)
				Console.Write ("{0} ", v[i]);
		}

		public static void Main (string[] args)
		{
			const int DIMENSION1 = 3;

			int[][] mat1 = new int[DIMENSION1][] {
				new int[4],
				new int[6],
				new int[10]
			};

			int[][] mat2;
			int[] valoresParaSegDimension = { 4, 12, 6, 7, 11 };

			Console.Title = "Recorriendo matrices escalonadas";

			Console.WriteLine ("Matriz 1");
			MostrarMEscalonada (mat1);
			InicializarAleatoria (mat1);
			MostrarMEscalonada (mat1);
			Console.WriteLine ("Matriz 2");
			mat2 = CrearMEscalonada (valoresParaSegDimension.Length, valoresParaSegDimension);
			MostrarMEscalonada (mat2);
			InicializarAleatoria (mat2);
			MostrarMEscalonada (mat2);
			
			
			int[] m1 = { 1, 1, 1 };
			int[] m2 = null;

			m2 = (int[])m1.Clone ();

			Console.WriteLine ("Matriz 1:");
			MostrarVector (m1);
			Console.WriteLine ("\nMatriz 2:");
			MostrarVector (m2);


			Console.ReadLine ();
		}
	}
}
