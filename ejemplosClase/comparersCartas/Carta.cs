using System;
using System.Collections;

namespace egb.ordenandoCartas
{
	public class Carta : IComparable<Carta>, IEquatable<Carta>
	{
		// Campos
		public int valor;
		public string imagen;
		public Palos palo;
		public Figuras figura;

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

		public Figuras Figura {
			get { return this.figura; }
			set { this.figura = value; }
		}

		public override string ToString ()
		{
			return string.Format ("Carta: {0} ({1}) de {2}", this.figura, this.valor, this.palo);
		}

		// Enumeracion
		public enum Palos {
			Oro, Copas, Espadas, Bastos
		}

		public enum Figuras {
			Uno, Dos, Tres, Cuatro, Cinco, Seis, Siete, Ocho, Nueve, Sota, Caballo, Rey
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

		public bool EsIgual(Carta c)
		{
			return (this.palo == c.palo) && (this.valor == c.valor);
		}

		public bool Equals(Carta c)
		{
			return (this.palo == c.palo) && (this.valor == c.valor);
		}

		// Constructores
		public Carta (Palos p, string i, int v)
		{
			this.palo = p;
			this.imagen = i;
			this.valor = v;
		}

		public Carta ()
		{
		}

		public Carta (Palos p, int v)
		{
			this.palo = p;
			this.valor = v;
		}

		public Carta (Palos p, int v, Figuras f)
		{
			this.palo = p;
			this.valor = v;
			this.figura = f;
		}
	}
}

