/*
    PROGRAMA: GranosDeTrigo
    AUTOR: Elena Guzman Blanco
    FECHA: 4/Nov/2016
    DESCRIPCION: Este programa calcula los granos de trigo que obtendría el aldeano en la fábula que te enseña que
    o aprendes matemáticas o te arruinas para siempre
*/

using System;

namespace GranosDeTrigo
{
	class GranosDeTrigo
	{
		static void Main(string[] args)
		{
			// Variables
			double contadorTrigo = 0;
			double multiploDos = 1;

			// Titulo de consola
			Console.Title = "Los granos de trigo";

			Console.WriteLine ("¿Cuantos granos de trigo pidio realmente el aldeano al sultán? \n\n");
            checked {
			    for (int i = 1; i < 65; i++) {
				        contadorTrigo = i * multiploDos; 
				        multiploDos *= 2;
				        if (i % 8 == 0)
					        Console.WriteLine ("Para la casilla {0,2}, {1} granos de trigo", i, contadorTrigo);
			    }
			}

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}
	}
}