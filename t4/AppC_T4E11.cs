/*
    PROGRAMA: ParametrosMain
    AUTOR: Elena Guzman Blanco
    FECHA: 2/Nov/2016
    DESCRIPCION: Este programa muestra los parámetros de Main en su invocacion por consola
*/

using System;

namespace ParametrosMain
{
	class ParametrosMain
	{
		public static void Main (string[] args)
		{
			// Titulo de consola
			Console.Title = "Mostrando parámetros de Main";

			Console.WriteLine ("Este programa muestra todos los argumentos pasados en su invocación por consola");
			Console.WriteLine ("¡Comenzamos!\n");

			foreach (string item in args) {
				Console.WriteLine (item);
			}

			// Fin de programa
			Console.WriteLine ("Pulsa ENTER para salir...");
			Console.ReadLine ();
		}

	}
}