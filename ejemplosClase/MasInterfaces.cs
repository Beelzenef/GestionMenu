using System;

namespace egb.Interfaces
{
	interface ICopias
	{
		void Copiar();
	}

	class Pila : ICopias
	{
		public void Clonar()
		{
			Console.WriteLine ("Soy Clonar() de PILA");
		}

		public void Copiar()
		{
			Console.WriteLine ("Soy Copiar() de PILA");
		}
	}

	class Factura : ICopias
	{
		public void Clonar()
		{
			Console.WriteLine ("Soy Clonar() de FACTURA");
		}

		public void Copiar()
		{
			Console.WriteLine ("Soy Copiar() de FACTURA");
		}
	}

	class Inicio
	{
		static void Main()
		{
			/*
			Pila unaPila = new Pila ();
			Factura unaFac = new Factura ();

			unaFac.Clonar ();
			unaFac.Copiar ();

			unaPila.Clonar ();
			unaPila.Copiar ();
			*/

			ICopias pila = new Pila ();
			ICopias factura = new Factura ();

			pila.Copiar ();
			factura.Copiar ();

			Console.ReadLine ();
		}
	}

}