//
//  Personaje.cs
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
using System.IO;

namespace Saludo
{
	public class Personaje
	{
		#region Campos
		int nivel;
		string nombre;
		int velocidad;
		int posicionX;
		int posicionY;
		char caracterPJ;

		string rutaDatos = string.Empty;
		#endregion

		#region Propiedades
		public int Nivel {
			get { return nivel; }
			set { nivel = value; }
		}

		public string Nombre {
			get { return nombre; }
			set { nombre = value; }
		}

		public int Velocidad {
			get { return velocidad; }
			set { velocidad = value; }
		}

		public int PosicionY {
			get { return posicionY; }
			set { posicionY = value; }
		}

		public int PosicionX {
			get { return posicionX; }
			set { posicionX = value; }
		}

		public char CaracterPJ {
			get { return caracterPJ; }
			set { caracterPJ = value; }
		}

		#endregion

		#region Metodos

		public bool GuardarPersonaje()
		{
			// Almacenando datos en un string
			string datos = Nombre + ";" +  Nivel.ToString () + ";" + Velocidad.ToString() + ";" +
				PosicionX.ToString() + ";" +  PosicionY.ToString() + ";" +  CaracterPJ.ToString();

			try {
				File.WriteAllText (rutaDatos, datos);
			}
			catch{
				Console.WriteLine ("No se ha podido guardar...");
			}
			return true;
		}

		public Personaje CargarPersonaje()
		{
			string[] datosCargados = new string[6];
			string datos = string.Empty;
			datos = File.ReadAllText (rutaDatos);

			datosCargados = datos.Split (';');

			// Nombre, nivel, velocidad, posX, posY, caracter
			Personaje unPJ = new Personaje (datosCargados[0], int.Parse(datosCargados[1]), int.Parse(datosCargados[2]),
				int.Parse(datosCargados[3]), int.Parse(datosCargados[4]), Char.Parse(datosCargados[5]));

			return unPJ;
		}

		#endregion

		public Personaje (string n, int lvl, int vel, int posx, int posY, char car)
		{
			Nombre = n;
			Nivel = lvl;
			Velocidad = vel;
			PosicionX = posx;
			PosicionY = posY;
			CaracterPJ = car;
		}
	}
}

