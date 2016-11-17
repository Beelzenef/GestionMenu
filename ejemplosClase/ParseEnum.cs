using System;

namespace ParseEnum
{
	class ParseEnum
	{
		enum Dias {
			Lunes = 1,
			Martes = 2,
			Miercoles = 3,
			Jueves = 4,
			Viernes = 5
		}

		static void Main(string[] args)
		{
			// Variables
			string[] dias = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "1", "3", "7"};

			// Convirtiendo strings a Dias (enum)
			Console.WriteLine ("Conversión de strings a enumeracion Dias");

			foreach (string item in dias) {
				try {
					Console.WriteLine ("El item {0} es {1} en enum Dias", item, Enum.Parse(typeof(Dias), item));
				}
				catch {
					Console.WriteLine ("No se ha podido convertir");
				}
			}

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}
	}
}
