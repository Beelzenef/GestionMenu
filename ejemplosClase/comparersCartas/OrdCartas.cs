using System;
using System.Collections.Generic;
using System.Threading;

namespace egb.ordenandoCartas
{
	class ordenandoCartas
	{
		static List<Carta> baraja = new List<Carta> (48);
		static Random dado = new Random ();

		static void ListarBaraja(List<Carta> b)
		{
			foreach (Carta item in b) {
				Console.WriteLine (item.ToString());
			}
		}

		static Carta CrearCarta()
		{
			Carta cartaTMP = new Carta ();
			int valor = 0;
			bool noValido = true;

			while (noValido) {
				if ((valor = dado.Next (1, 13)) != 8 && valor != 9)
					noValido = false;
			}
			cartaTMP = new Carta ((Carta.Palos)dado.Next (0, 4), valor, (Carta.Figuras)(valor - 1));
			return cartaTMP;
		}

		public static void Main (string[] args)
		{
			Console.Title = "Operando con cartas";

			for (int i = 0; i < 50; i++) {
				baraja.Add(CrearCarta ());
			}
			ListarBaraja (baraja);
			Console.ReadLine ();

			baraja.Sort(new OrdenAscPorValor());
			Console.WriteLine ("\nPor valor:");
			ListarBaraja (baraja);
			baraja.Sort(new OrdenDescPorPalos());
			Console.WriteLine ("Por palos:");
			ListarBaraja (baraja);
			baraja.Sort(new OrdenAscPorFiguras());
			Console.WriteLine ("Por figuras:");
			ListarBaraja (baraja);

			Console.ReadLine ();
		}
	}
}