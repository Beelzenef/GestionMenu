using System;

namespace ProbandoTipos
{
	class ProbandoTipos
	{
		static void Main(string[] args)
		{
			// Variables, objetos que representan varios tipos de datos diferentes
			object numero = 10;
			object letra = 'A';
			object texto = "OMG";
			int entero = 5;
			Simple simplecillo = new Simple ();

			// Titulo de consola
			Console.Title = "Jugando con tipos";

			Console.WriteLine ("El valor de numero (object) es {0}", numero);
			Console.WriteLine ("El valor de numero (object) {0} + entero (entero) {1}, es {2}", numero, entero, (int)numero + entero);

			simplecillo.Cambia (entero);
			Console.WriteLine ("\nEl valor de entero, sin guardar el resultado del método, que no cambia: {0}", entero);
			entero = simplecillo.Cambia (entero);
			Console.WriteLine ("El valor de entero, guardando el resultado del método, cambia: {0}", entero);

			simplecillo.Cambia (ref entero);
			Console.WriteLine ("\nMétodo donde entero es por referencia, el valor cambia sin guardar resultado: {0}", entero);

			Console.WriteLine ("\nEl tipo de variable letra (object) es de {0}", letra.GetType());
			Console.WriteLine ("El tipo de variable texto (object) es de {0}", texto.GetType());
			Console.WriteLine ("Al tomar valores, se asume un tipo de dato concreto");
			Console.WriteLine ("Pero para operar, necesitaré conversiones :D");

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}
	}

	class Simple
	{
		// Campos
		int numero = 0;

		/// <summary>
		/// Cambia el valor recibido a su doble
		/// </summary>
		/// <param name="dato">Numero a doblar</param>
		public int Cambia(int dato)
		{
			return dato * 2;
		}

		public int Cambia(ref int dato)
		{
			dato *= 2;
			return dato;
		}
	}
}
