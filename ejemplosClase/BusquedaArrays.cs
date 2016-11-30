using System;

namespace BusquedaArrays
{
	class BusquedaArrays
	{
		static int nDatos = 0;
		
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
			
			// Otras operaciones
			const int POSICIONES = 100;
			int[] numeritos = new int[POSICIONES];

			Console.WriteLine ("Listando array:");
			Listar (numeritos);
			Console.WriteLine ("Introduciendo tres valores nuevos...");
			Anadir (numeritos, 12);
			Anadir (numeritos, 56);
			Anadir (numeritos, 254);
			Console.WriteLine ("Listando array:");
			Listar (numeritos);
			Console.WriteLine ("Añadiendo 10 datos aleatorios nuevos");
			Console.WriteLine ("El array ha acumulado {0} valores nuevos ", Anadir (numeritos, 10, 100));
			Console.WriteLine ("Listando array:");
			Listar(numeritos);
			Borrar (numeritos, 1);
			Console.WriteLine ("Listando array:");
			Listar(numeritos);

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

		static bool Anadir(int[] vector, int dato)
		{
			if (vector.Length == nDatos)
				return false;
			vector [nDatos++] = dato;
			return true;
		}

		static int Anadir(int[] vector, int nDatosAleatorios, int maximo)
		{
			if (nDatos == vector.Length)
				return 0;

			Random dado = new Random ();
			int contadorDatosAnadidos = 0;

			for (int i = 0; i < nDatosAleatorios; i++)
				if (Anadir (vector, dado.Next (maximo)))
					contadorDatosAnadidos++;
			return contadorDatosAnadidos;
		}
		
		static bool Insertar(int[] vector, int dato, int posicion)
		{
			if (nDatos == vector.Length || posicion < 0 || posicion > nDatos)
				return false;
			
			for (int i = nDatos; i > posicion; i--)
				vector [i] = vector [i - 1];
			vector[posicion] = dato;
			nDatos++;
			return true;
		}

		static void Listar(int[] vector)
		{
			if (nDatos == 0) {
				Console.WriteLine ("Array vacío, pulsa ENTER para continuar...");
				Console.ReadLine ();
			} else {
				for (int i = 0; i < nDatos; i++)
					Console.Write ("{0} ", vector [i].ToString ());
				Console.WriteLine ("\nSin más datos a listar...");
			}
		}


	}
}

