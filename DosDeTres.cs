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

namespace DosDeTres
{
	class DosDeTres
	{
		public static void Main (string[] args)
		{
			// Comprueba si, de tres numeros, la suma de dos de ellos resulta en el primero

			// Declarando variables
			int primero = 0;
			int segundo = 0;
			int tercero = 0;
			int flag = 0;

			// Tomando numeros
			Console.WriteLine ("Comprobaremos si, de tres numeros, la suma de dos de ellos resulta en el primero");
			Console.WriteLine ("Dame el primero");
			primero = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Dame el segundo");
			segundo = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Dame el tercero");
			tercero = int.Parse (Console.ReadLine ());
			Console.WriteLine ("Calculando...");

			// Marcando pasos por el flujo en flag
			if (primero + segundo == tercero)
				flag++;
			if (segundo + tercero == primero)
				flag++;
			if (primero + tercero == segundo)
				flag++;

			// Marcando resultado
			if (flag == 0)
				Console.WriteLine ("No ha resultado ninguna suma");
			else
				Console.WriteLine ("Una suma ha surgido entre los numeros introducidos");

			// Salida
			Console.WriteLine ();
			Console.WriteLine ("Pulsa ENTER para salir...");
			Console.ReadLine ();
		}
	}
}
