﻿/*
    PROGRAMA: UnMenu
    AUTOR: Elena Guzman Blanco
    FECHA: 2/Nov/2016
    DESCRIPCION: Este programa muestra un menu con gestion de respuesta
*/

using System;

namespace UnMenu
{
	class UnMenu
	{
		static void Main(string[] args)
		{
			// Variables
			ConsoleKeyInfo teclita;

			// Titulo de consola
			Console.Title = "Menu de altas";

			do {
				Console.Clear();
				DibujarMenu ();

				teclita = Console.ReadKey ();
				GestionarOpciones (teclita);
			
			} while (teclita.KeyChar != '0');

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}

		static void GestionarOpciones(ConsoleKeyInfo opcion)
		{
			Console.WriteLine ();
			switch (opcion.KeyChar) {
			case '1':
				Console.WriteLine ("Has seleccionado ALTAS");
				break;
			case '2':
				Console.WriteLine ("Has seleccionado BAJAS");
				break;
			case '3':
				Console.WriteLine ("Has seleccionado MODIFICACIONES");
				break;
			case '4':
				Console.WriteLine ("Has seleccionado CONSULTAS");
				break;
			case '0':
				Console.WriteLine ("Saliendo del programa");
				break;
			default:
				Console.WriteLine ("Por favor, seleccione opciones entre 1 y 4");
				break;
			}

			Console.ReadLine ();

		}

		static void DibujarMenu()
		{
			Console.WriteLine ("===========================================");
			Console.WriteLine ("      M E N U  P R I N C I P A L");
			Console.WriteLine ("===========================================");
			Console.WriteLine ("      1. Altas");
			Console.WriteLine ("      2. Bajas");
			Console.WriteLine ("      3. Modificaciones");
			Console.WriteLine ("      4. Consultas");
			Console.WriteLine ("\n      0. Salir");
			Console.Write ("      Por favor, pulsa una opcion ");
		}

	}
}
