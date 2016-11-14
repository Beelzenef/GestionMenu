using System;

namespace EnumeracionesVarias
{
	class EnumeracionesVarias
	{
		enum Dedos {
			Pulgar,
			Indice,
			Corazon,
			Anular,
			Meñique
		}

		static void Main(string[] args)
		{
			// Variables
			Dedos dedoPocho;
			dedoPocho = Dedos.Corazon;
			Random dado = new Random ();

			// Titulo de consola
			Console.Title = "Enumeraciones varias";

			Console.WriteLine ("Tu dedo pocho es {0}", dedoPocho.ToString());
			Console.WriteLine ("El numero de tu dedo pocho es {0}", (int)dedoPocho);
			Console.WriteLine ("El nombre de tu dedo pocho es {0}", (Dedos)2);

			Console.WriteLine ("\nDedos aleatorios");
			Console.WriteLine ("El dedo {0}", (Dedos)dado.Next(5));

			Console.WriteLine ("\n\nMostrando la lista de los dedos");

			for (int i = (int)Dedos.Pulgar; i <= (int)Dedos.Meñique; i++) {
				Console.WriteLine ((Dedos)i);
			}

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}
	}
}
