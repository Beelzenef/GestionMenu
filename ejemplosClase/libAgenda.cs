using System;

namespace egb.Agenda
{
	public class Agenda
	{
		// Campos
		const int NMAXIMOENTRADAS = 100;
		string[] listaAnotaciones = new string[NMAXIMOENTRADAS];
		int ultimaAnotacion = 0;

		// Propiedades

		/// <summary>
		/// Obtiene el número de anotaciones en la agenda
		/// </summary>
		public int Longitud
		{
			get { return ultimaAnotacion; }
		}

		// Operadores

		/// <param name="unaAgenda">Una agenda.</param>
		/// <param name="anotacion">Anotacion.</param>
		public static bool operator +(Agenda unaAgenda, string anotacion)
		{
			if (unaAgenda.ultimaAnotacion == NMAXIMOENTRADAS)
				return false;
			unaAgenda.listaAnotaciones [unaAgenda.ultimaAnotacion++] = anotacion;
			return true;
		}

		// Indices

		/// <summary>
		/// Obtiene o establece una nota en una determinada posicion
		/// </summary>
		/// <param name="indice">Indice donde se encuentra o encontrará la nota</param>
		public string this[int indice]
		{
			get {
				if (indice < 0 || indice >= ultimaAnotacion)
					throw new IndexOutOfRangeException ("Indice no valido");
				return listaAnotaciones [indice];
			}
			set {
				if (indice == NMAXIMOENTRADAS)
					throw new IndexOutOfRangeException ("Indice no valido");
				if (indice >= ultimaAnotacion)
					AddAnotacion (value);
				else
					listaAnotaciones [indice] = value;
			}
		}

		// Metodos

		/// <summary>
		/// Agrega una anotacion pasada como parámetro
		/// </summary>
		/// <returns><c>true</c>, si la anotacion se agrega, <c>false</c> en otro caso</returns>
		/// <param name="nota">Nota a agregar</param>
		public bool AddAnotacion(string nota)
		{
			if (ultimaAnotacion == NMAXIMOENTRADAS)
				return false;
			listaAnotaciones [ultimaAnotacion++] = nota;
			return true;
		}

		/// <summary>
		/// Recorre todas las anotaciones y las muestras por consola
		/// </summary>
		public void MostrarAnotaciones()
		{
			Console.WriteLine ("Datos de la agenda " + this.ToString());
			for (int i = 0; i < ultimaAnotacion; i++) {
				Console.WriteLine ("{0}.- {1}", i, listaAnotaciones[i]);
			}
			Console.WriteLine ("\nFin del listado");
		}
	}
}

