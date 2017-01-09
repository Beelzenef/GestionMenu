using System;
using System.Collections.Generic;

namespace egb.ordenandoCartas
{
	class ordenandoCartas
	{
		static List<Carta> Baraja = new List<Carta> (48);

		static void ListarBaraja(List<Carta> b)
		{
			foreach (Carta item in b) {
				Console.WriteLine ("Carta: {0,2}\t{1}", item.Valor, item.Palo);
			}
		}

		public static void Main (string[] args)
		{
			Console.Title = "Operando con diccionarios";

			Baraja.Add (new Carta (Carta.Palos.Bastos, 1));
			Baraja.Add (new Carta (Carta.Palos.Espadas, 6));
			Baraja.Add (new Carta (Carta.Palos.Oro, 12));
			Baraja.Add (new Carta (Carta.Palos.Oro, 2));
			Baraja.Add (new Carta (Carta.Palos.Copas, 4));
			Baraja.Add (new Carta (Carta.Palos.Espadas, 2));
			Baraja.Add (new Carta (Carta.Palos.Espadas, 5));

			Console.WriteLine ("\nListado de la baraja");
			ListarBaraja (Baraja);

			Console.WriteLine ("\nListado de la baraja ordenada");
			Baraja.Sort ();
			ListarBaraja (Baraja);

			Console.ReadLine ();
		}
	}
}