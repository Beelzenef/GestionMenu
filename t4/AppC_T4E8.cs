/*
    PROGRAMA: ConvertirAMayuscula
    AUTOR: Elena Guzman Blanco
    FECHA: 7/Nov/2016
    DESCRIPCION: Este programa muestra la mayuscula de un caracter de letra especificado
*/

using System;

namespace ConvertirAMayuscula
{
	class ConvertirAMayuscula
	{
		static void Main(string[] args)
		{
			// Variables
			ConsoleKeyInfo tecla;

			// Titulo de consola
			Console.Title = "Convirtiendo a Mayusculas";

			Console.WriteLine ("Este programa convierte a mayusculas cualquier caracter de letra que introduzcas\n\n");

			Console.Write ("¿Cual es tu caracter? ");
			tecla = Console.ReadKey ();
			Console.WriteLine ("\nConvirtiendo...\n");
			Console.WriteLine ("Tu caracter es {0} y su mayuscula es, de existir, {1}", tecla.KeyChar, AMayuscula (tecla.KeyChar));

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();
		}

		static char AMayuscula(char caracterAConvertir)
		{
			// Variables
			int numCaracter = (int)caracterAConvertir;
			int nuevoValor = 0;
			char caracterADevolver = ' ';

			// Comprobando si está en el rango de letras, si isLetter(), de lo contrario, devolverá el mismo caracter
			if (Char.IsLetter(caracterAConvertir)) {
				nuevoValor = numCaracter - 32;
				caracterADevolver = (char)nuevoValor;
				}
			else
				caracterADevolver = caracterAConvertir;

			return caracterADevolver;
		}
	}
}