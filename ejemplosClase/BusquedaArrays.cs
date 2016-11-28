using System;

namespace BusquedaArrays
{
	class BusquedaArrays
	{
		static void Main(string[] args)
		{
			// Variables
			int[] vector = { 1, 2, 5, 6, 7, 8, 11 };
			int datoEncontrado = 0;
			int[] nuevoVector;

			// Titulo de consola
			Console.Title = "Algoritmos de busqueda en arrays (pt1)";

			Console.WriteLine ("Busqueda secuencial de un dato, {0}", 5);
			datoEncontrado = BusquedaSec (5, vector);

			if (datoEncontrado != -1)
				Console.WriteLine ("El dato buscado en la pos. {0} y vale {1}", datoEncontrado + 1, vector[datoEncontrado]);
			else
				Console.WriteLine ("El dato no se encuentra en el array");

			Console.WriteLine ("\n\nBusqueda binaria de un dato, {0}", 5);
			datoEncontrado = BusquedaBin (5, vector);

			if (datoEncontrado != -1)
				Console.WriteLine ("El dato buscado en la pos. {0} y vale {1}", datoEncontrado + 1, vector[datoEncontrado]);
			else
				Console.WriteLine ("El dato no se encuentra en el array");

			try {
				nuevoVector = CrearArray (10000);
				Console.WriteLine ("\n\nBusqueda binaria de un dato, {0}", 1678);
				datoEncontrado = BusquedaBin (1678, nuevoVector);

				if (datoEncontrado != -1)
					Console.WriteLine ("El dato buscado en la pos. {0} y vale {1}", datoEncontrado + 1, nuevoVector[datoEncontrado]);
				else
					Console.WriteLine ("El dato no se encuentra en el array");
			}
			catch {
				Console.WriteLine ("Error rellenando array");
			}

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}

		static int[] CrearArray(int longitud)
		{
			int[] vectorNuevo = new int[longitud];

			for (int i = 0; i < longitud; i++)
				vectorNuevo [i] = i + 1;

			return vectorNuevo;
		}

		static void RecorrerArray(int[] unArray)
		{
			for (int i = 0; i < unArray.Length; i++) {
				Console.Write ("{0} ", unArray [i]);
			}
		}

		/// <summary>
		/// Realiza busqueda secuencial del dato en el array "vector"
		/// </summary>
		/// <returns>Indice del dato a buscar, -1 si no lo encuentra</returns>
		/// <param name="datoABuscar">Dato a buscar.</param>
		/// <param name="vector">Nombre del array </param>
		/// <param name="nDatos">Numero de datos entre los que buscar</param>
		static int BusquedaSec(int datoABuscar, int[] vector, int nDatos)
		{
			for (int i = 0; i < nDatos; i++)
				if (datoABuscar == vector[i])
					return i;
			return -1;    
		}

		static int BusquedaSec(int datoABuscar, int[] vector)
		{
			for (int i = 0; i < vector.Length; i++)
				if (datoABuscar == vector[i])
					return i;
			return -1;    
		}

		static int BusquedaBin(int datoABuscar, int[] vector)
		{
			int posIni = 0;
			int tamanio = vector.Length;
			int posFinal = tamanio - 1;
			int posMedio = (posIni + posFinal) / 2;;

			while (vector [posMedio] != datoABuscar && posIni <= posFinal) {
				posMedio = (posIni + posFinal) / 2;
				if (datoABuscar > vector [posMedio])
					posIni = posMedio + 1;
				else
					posFinal = posMedio - 1;
			}
			// ¿Ha encontrado el dato?
			if (vector [posMedio] == datoABuscar)
				return posMedio;
			return -1;
		}

	}
}

