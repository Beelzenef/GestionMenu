/*
    PROGRAMA: EscapandoCaracteres
    AUTOR: Elena Guzman Blanco
    FECHA: 17/Oct/2016
    DESCRIPCION: Este programa muestra por pantalla caracteres especiales
*/

using System;

namespace AppC_T3E13
{
	class AppC_T3E13
	{
		public static void Main (string[] args)
		{
			Console.Title = "Caracteres especiales";
			Console.WriteLine ("Mostrando caracteres especiales por pantalla... \n");

			Console.WriteLine ("Las comillas dobles (\") son especiales dentro del método Write");
			Console.WriteLine ("Esto es una barra invertida: \\");
			Console.WriteLine ("El caracter \"\\t\" es una tabulacion horizontal");
			Console.WriteLine ("El caracter \"\\n\" es un salto de linea");
			Console.WriteLine ("Los caracteres {} son especiales");
			Console.WriteLine ("El primer valor se sustituye por {{0}} y vale {0}", 5);

			//Salida
			Console.WriteLine("\n\nPulsa ENTER para salir del programa");
			Console.ReadLine();
		}
	}
}
