using System;

namespace egb.expLambda
{
	delegate int delegadito (int i);
	delegate string delegadito2 (string s);
	delegate int delegadito3 (string s);

	class Inicio
	{
		static void Main()
		{
			int resultado = 0;

			delegadito miDlg = (x) => x + x;
			resultado = miDlg ('A');

			delegadito2 miDlg2 = (x) => x + x;

			delegadito3 miDlg3 = (x) => (x + x + x).Length;

			Console.WriteLine (resultado);
			Console.WriteLine (miDlg2("hey"));
			Console.WriteLine (miDlg3("hey"));

			Console.ReadLine ();
		}
	}
}