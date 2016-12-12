using System;

namespace opStrings
{
	class opStrings
	{
		static string EjemplosString()
		{
			double valor = 0;
			string resultado = string.Empty;

			string nuevaLinea = Environment.NewLine;

			// Mostrando resultados con formato
			// 		Salida: 00123
			valor = 123;
			resultado = valor.ToString("00000") + nuevaLinea;
			//		Salida: 1.234.567.890
			valor = 1234567890;
			resultado += valor.ToString ("0,0") + nuevaLinea;
			// 		Salida: 1.234.567.890,12
			valor = 1234567890.12345;
			resultado += valor.ToString ("0,0.00") + nuevaLinea;

			return resultado;
		}

		static void EjemploCopia()
		{
			char[] textillo = { 'h', 'o', 'l', 'a', ' ', 'm', 'u', 'n', 'd', 'o' };
			int posIniOrigen = 9;
			int posIniDestino = 5;
			int nCaracteresACopiar = 2;
			string origen = "learning C#";

			origen.CopyTo (posIniOrigen, textillo, posIniDestino, nCaracteresACopiar);

			Console.WriteLine (textillo);
		}

		static void ComparandoStrings()
		{
			Console.WriteLine ("a".CompareTo("b"));
			Console.WriteLine ("a".CompareTo("a"));
			Console.WriteLine ("b".CompareTo("a"));
		}

		static int CompararStrings(string cadenaA, string cadenaB)
		{
			if (cadenaA.Length > cadenaB.Length)
				return 1;
			if (cadenaA.Length < cadenaB.Length)
				return -1;

			for (int i = 0; i < cadenaA.Length; i++) {
				if (cadenaA [i] > cadenaB [i])
					return 1;
				if (cadenaA [i] < cadenaB [i])
					return -1;
			}
			return 0;
		}

		static int CompararStrings(string cadenaA, string cadenaB, bool ignoraMayus)
		{
			if (ignoraMayus) {
				cadenaA = cadenaA.ToLower ();
				cadenaB = cadenaB.ToLower ();
			}

			if (cadenaA.Length > cadenaB.Length)
				return 1;
			if (cadenaA.Length < cadenaB.Length)
				return -1;

			for (int i = 0; i < cadenaA.Length; i++) {
				if (cadenaA [i] > cadenaB [i])
					return 1;
				if (cadenaA [i] < cadenaB [i])
					return -1;
			}
			return 0;
		}

		static string Trimeando(string cadenaPrueba) {
			string resultado = string.Empty;

			resultado = cadenaPrueba.Trim (new char[] { '-' });

			return resultado;
		}

		static string UsoSubstring(string cadenaOrigen)
		{
			int posIni = 9;
			int nCaracteres = 2;

			return cadenaOrigen.Substring (posIni, nCaracteres);

		}

		static void SeparandoPalabras(string frase)
		{
			char[] separadores = new char[] { ' ', '.', ',' };
			string[] listaPalabras = frase.Split (separadores, StringSplitOptions.RemoveEmptyEntries);

			Console.WriteLine ("Hay {0} palabras en tu texto", listaPalabras.Length);
			foreach (string item in listaPalabras) {
				Console.WriteLine (item);
			}
		}

		public static void Main (string[] args)
		{
			Console.Title = "Operando strings";
			Console.WriteLine ("> Probando formatos");
			Console.WriteLine (EjemplosString ());

			Console.WriteLine ("> Copiando strings");
			EjemploCopia ();

			Console.WriteLine ("\n> CompareTo()");
			ComparandoStrings ();

			Console.WriteLine ("\n> CompararStrings()");
			Console.WriteLine ("Comparando {0} y {1}, devuelve {2}", "hola mundo", "hola mundo", CompararStrings("hola mundo", "hola mundo"));
			Console.WriteLine ("Comparando {0} y {1}, devuelve {2}", "hola", "halo", CompararStrings("hola", "halo"));
			Console.WriteLine ("Comparando {0} y {1}, devuelve {2}", "hola", "holo", CompararStrings("hola", "holo"));
			Console.WriteLine ("Comparando {0} y {1}, devuelve {2}", "hola", "HOLA", CompararStrings("hola", "HOLA", true));

			Console.WriteLine ("\n> Trim de guiones");
			Console.WriteLine ("De \"{0}\" surge \"{1}\"", "-hey-", Trimeando("-hey-"));

			Console.WriteLine ("\n> Usando Substring()");
			Console.WriteLine ("De \"{0}\", se extrae \"{1}\"", "learning C#", UsoSubstring("learning C#"));

			Console.WriteLine ("\n> Split()");
			SeparandoPalabras ("hey there watcha doing, lol  hey  wut.     lol");

			Console.ReadLine ();
		}
	}
}
