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

namespace menu
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int col = 20;
			int fila = 8;

			int opcionSeleccionada = 0;

			// Posicionando cursor
			Console.SetCursorPosition(col, fila);

			// Pintando menu
			Console.BackgroundColor = ConsoleColor.Blue;
			Console.WriteLine ("       Menu principal      ");
			Console.CursorLeft = col;
			Console.BackgroundColor = ConsoleColor.Red;
			Console.WriteLine ("   1. Opcion 1             ");
			Console.CursorLeft = col;
			Console.WriteLine ("   2. Opcion 2             ");
			Console.CursorLeft = col;
			Console.WriteLine ("   3. Opcion 3             ");
			Console.CursorLeft = col;
			Console.WriteLine ("   Selecciona tu opcion    ");

			// Tomando opciones
			Console.SetCursorPosition (45, 12);
			try {
				opcionSeleccionada = int.Parse(Console.ReadLine());
				Console.CursorTop = 1;
				Console.CursorLeft = col;
				Console.WriteLine ("Tu opcion es la " + opcionSeleccionada);
			} catch {
				Console.WriteLine ("No es una opcion válida");
			}
		
			Console.CursorVisible = false;
			Console.ReadLine ();
		}
	}
}
