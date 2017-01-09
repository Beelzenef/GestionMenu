using System;
using System.Collections;

namespace egb.ordenandoCartas
{
	public class Carta : IComparable<Carta>
	{
		// Campos
		public int valor;
		public string imagen;
		public Palos palo;

		// Propiedades
		public int Valor {
			get { return this.valor; }
			set { this.valor = value; }
		}

		public string Imagen {
			get { return this.imagen; }
			set { this.imagen = value; }
		}

		public Palos Palo {
			get { return this.palo; }
			set { this.palo = value; }
		}

		// Enumeracion
		public enum Palos {
			Oro, Copas, Espadas, Bastos
		}

		// Metodos
		public int CompareTo(Carta o)
		{
			int comparador = this.palo.CompareTo (o.palo);

			if (comparador != 0)
				return comparador;
			comparador = this.valor.CompareTo (o.valor);
			return comparador;
		}

		// Constructores
		public Carta (Palos p, string i, int v)
		{
			this.palo = p;
			this.imagen = i;
			this.valor = v;
		}

		public Carta (Palos p, int v)
		{
			this.palo = p;
			this.valor = v;
		}
	}
}

