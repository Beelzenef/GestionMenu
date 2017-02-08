using System;
using System.Collections.Generic;

namespace egb.oop
{
	delegate int dlgCuadrado(int x);

	class ListaNumerosNoRepetidos
	{
		static int Cuadrado (int x)
		{
			return x * x;
		}

		static void Main (string[] args)
		{
			Console.Title = "Delegados a través del tiempo";

			int numero = 10;

			Console.WriteLine ("\n===== C# v1.0 - Uso de delegados =====");
			dlgCuadrado dc1 = new dlgCuadrado (Cuadrado);
			Console.WriteLine ("\tUsando delegado dlgCuadrado, resultado es {0}", dc1 (numero).ToString());

			Console.WriteLine ("\n===== C# v2.0 - Delegados con codigo de inic. (metodos anonimos) =====");
			dlgCuadrado dc2 = delegate(int x) {
				return x * x;
			};
			Console.WriteLine ("\tUsando metodo anonimo, resultado es {0}", dc2 (numero).ToString());

			Console.WriteLine ("\n===== C# v3.0 - Delegados y expresiones lambda =====");
			dlgCuadrado dc3 = x => x * x;
			Console.WriteLine ("\tUsando expresion lambda, resultado es {0}", dc3 (numero).ToString());

			Console.WriteLine ("\n===== C# v3.0 - Delegado generico integrado con expresiones lambda =====");
			Func<int, int> dc4 = x => x * x;
			Console.WriteLine ("\tUsando delegado generico int. con exp.lambda, resultado es {0}", dc4 (numero).ToString());

			Console.ReadLine ();
		}
	}

}
