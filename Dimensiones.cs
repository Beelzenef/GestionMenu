//
//  Program.cs
//
//  Author:
//       Elena (Beelzenef) <elena.guzbla@gmail.com>
//
//  Copyright (c) 2016 Elena Guzman Blanco
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace DimensionesYColores
{
	class DimensionesYColores
	{
		public static void Main (string[] args)
		{
			// Declarando variables
			Console.Clear();
			int altoGuardado = Console.WindowHeight;
			int anchoGuardado = Console.WindowWidth;
			ConsoleColor backGuardado = Console.BackgroundColor;
			ConsoleColor foreGuardado = Console.ForegroundColor;
			int incAnchoYAlto = 10;
			string lineaVacia = "                                                                    ";

			// Mostrando datos de la pantalla
			Console.WriteLine ("Hello World!");
			Console.WriteLine ("Ancho máximo posible: {0}", Console.LargestWindowWidth);
			Console.WriteLine ("Alto máximo posible:  {0}", Console.LargestWindowHeight);
			Console.WriteLine ("Ancho actual:         {0}", Console.WindowWidth);
			Console.WriteLine ("Alto actual:          {0}", Console.WindowHeight);
			Console.ReadLine ();

			// Cambiando cosis
			if (anchoGuardado + incAnchoYAlto < Console.LargestWindowWidth)
				Console.WindowWidth = anchoGuardado + incAnchoYAlto;
			if (altoGuardado + incAnchoYAlto < Console.LargestWindowHeight)
				Console.WindowHeight = altoGuardado + incAnchoYAlto;
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine ("Colores y dimensiones cambiados");
			Console.WriteLine (lineaVacia);
			Console.WriteLine ("Ancho actual:         {0}", Console.WindowWidth);
			Console.WriteLine ("Alto actual:          {0}", Console.WindowHeight);

			// Restaurando
			if (Console.WindowWidth != anchoGuardado)
				Console.WindowWidth = anchoGuardado;
			if (Console.WindowHeight != altoGuardado)
				Console.WindowHeight = altoGuardado;
			Console.BackgroundColor = backGuardado;
			Console.ForegroundColor = foreGuardado;
			Console.WriteLine ("Volviendo a la normalidad...");

			// Salida
			Console.Write ("Pulsa ENTER para salir...");
			Console.ReadLine ();
		}
	}
}
