using System;

namespace Tipos
{
	class Tipos
	{
		static void Main(string[] args)
		{
			// Variables
			byte numeroByte = 255;
			char asterisco = '*';

			// Jugando con bytes y desbordamientos
			Console.WriteLine ("\t Byte > " + numeroByte);

			try {
				checked
				{
					Console.WriteLine ("\t Byte++ > " + ++numeroByte);
				}
			}
			catch
			{
				Console.WriteLine ("Debordamiento ha ocurrido");
			}

			Console.WriteLine ("\t Byte++ > " + ++numeroByte);

			// Jugando con caracteres y UNICODE
			Console.WriteLine ();
			Console.WriteLine ("Mostrando un caracter {0} y su UNICODE {1}", asterisco, (int)asterisco);
			Console.WriteLine ("Y el siguiente unicode es... {0} y {1}", ++asterisco, (char)((int)asterisco) + 1);

			Console.WriteLine ("La letra A >\t" + (int)'A');
			Console.WriteLine ("El UNICODE 65 >\t" + (char)65);

			// Salida
			Console.WriteLine ("Pulsa ENTER para salir...");
			Console.ReadLine ();
		}
	}
}
