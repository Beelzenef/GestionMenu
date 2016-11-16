using System;

namespace EnumsFlags
{
	class EnumsFlags
	{
		[Flags]
		enum Dedos {
			Pulgar = 0x00000001,
			Indice = 0x00000002,
			Corazon = 0x00000004,
			Anular = 0x00000008,
			Meñique = 0x00000016
		}

		static void Main(string[] args)
		{
			// Variables
			Dedos unDedo;
			unDedo = Dedos.Anular;
			Dedos otroDedo = Dedos.Anular | Dedos.Indice;

			// Titulo de consola
			Console.Title = "Enums y Flags";

			Console.WriteLine ("Un dedo {0} es {1}", Enum.GetName(typeof(Dedos), unDedo), unDedo);
			Console.WriteLine ("Operacion OR de bits para dos dedos: {0}", otroDedo);
			Console.WriteLine ("Como operas OR, sumas los dos valores {0}", (int)otroDedo);

			string[] listaDedos = Enum.GetNames (typeof(Dedos));
			Console.WriteLine ("\nLa enumeracion de dedos tiene {0} elementos", listaDedos.Length);
			Console.WriteLine ("Listando dedos:");
			foreach (string item in listaDedos) {
				Console.WriteLine (item);
			}

			Console.ReadLine ();

			string[] listaTeclas = Enum.GetNames (typeof(ConsoleKey));
			Console.WriteLine ("\nLa enumeracion de teclas tiene {0} elementos", listaTeclas.Length);
			Console.WriteLine ("Listando teclas:");
			foreach (string item in listaTeclas) {
				Console.WriteLine (item);
			}

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}
	}
}
