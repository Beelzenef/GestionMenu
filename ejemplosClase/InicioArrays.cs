using System;

namespace InicioArrays
{
	class InicioArrays
	{
		static void Main(string[] args)
		{
			// Constantes varias...
			const double IVA = 21.33;
			const double VALOR = 12.33 * IVA;

			const int LONGITUDARRAYS = 15;

			// Inicializando arrays
	
			int[] numeros;
			numeros = new int[LONGITUDARRAYS];

			int[] listaNums1 = new int[LONGITUDARRAYS];

			int[] listaNums2 = { 1, 3, 44 };

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}
	}
}
