using System;
using System.Collections.Generic;

namespace egb.ordenandoCartas
{
	public class OrdenAscPorValor : IComparer<Carta>
	{
		public int Compare(Carta x, Carta y)
		{
			return x.Valor.CompareTo (y.Valor);
		}
	}
}