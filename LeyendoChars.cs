using System;

namespace LeyendoChars
{
	class LeyendoChars
	{
		static void Main(string[] args)
		{
			// Variables
			Char caracter;

			// Titulo de consola
			Console.Title = "Leyendo Chars";
		
			Console.WriteLine ("Leyendo caracteres, informacion sobre los mismos");
			Console.Write ("\t¿Cual es tu caracter? ");
			caracter = Console.ReadKey ().KeyChar;

			// Informacion del caracter
			Console.WriteLine ("\n\nTu caracter es " + caracter.ToString());
			Console.WriteLine ("\t\t             ¿Es digito? " + Char.IsDigit(caracter));
			Console.WriteLine ("\t\t              ¿Es letra? " + Char.IsLetter(caracter));
			Console.WriteLine ("\t\t¿Es signo de puntuacion? " + Char.IsPunctuation(caracter));
			Console.WriteLine ("\t\t          ¿Es separador? " + Char.IsSeparator(caracter));
			Console.WriteLine ("\t\t            ¿Es simbolo? " + Char.IsSymbol(caracter));
			Console.WriteLine ("\t\t           En mayuscula: " + Char.ToUpper(caracter));

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}

	}
}
