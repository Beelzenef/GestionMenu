using System;

namespace LeerSoloNums
{
	class LeerSoloNums
	{
		static int BusquedaBin(char datoABuscar, char[] vector)
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

		static int LeerSoloNumeros()
		{
			char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'  };
			string numeroAConvertir = string.Empty;
			ConsoleKeyInfo tecla;

			do {
				tecla = Console.ReadKey (true);
				if (BusquedaBin (tecla.KeyChar, numeros) != -1) {
					Console.Write (tecla.KeyChar);
					numeroAConvertir += tecla.KeyChar.ToString ();
				}
			} while (tecla.Key != ConsoleKey.Enter);

			return int.Parse(numeroAConvertir);
		}

		public static void Main (string[] args)
		{
			Console.Title = "Leyendo solo numeros";

			int num = 0;
			Console.WriteLine ("Dame un numero");
			num = LeerSoloNumeros ();
			Console.WriteLine ("\nTu numero es {0}", num);

			Console.ReadLine ();
		}
	}
}
