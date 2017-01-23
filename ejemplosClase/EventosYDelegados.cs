using System;

namespace egb.AprendiendoEventos
{
	// Creando un delegado público de uso propio:
	public delegate void DlgTickReloj (int t);

	class Contador
	{
		/// <summary>
		/// Simula un contador que genera una señal cada vez que este cambie
		/// </summary>
		public void Inicio()
		{
			for (int i = 0; i < 1000; i++) {
				if (i % 100 == 0) {
					if (Ticking != null)
						Ticking (i);
				}
				if (i % 10 == 0) {
					if (MutiploDe10 != null)
						MutiploDe10 (null, null);
				}
				if (i == 999) {
					if (FinCuenta != null)
						FinCuenta (null, null);
				}
			}
		}

		// Creando un evento público basado en el delegado DltTickReloj:
		public event DlgTickReloj Ticking;
		// Otros eventos, con delegado EventHandler
		public event EventHandler MutiploDe10;
		public event EventHandler FinCuenta;

		public Contador()
		{
			// No es necesario, pues se inicializa a null automáticamente
			// Dejará de ser null cuando una instancia de esta Clase en otra Clase se suscriba al evento
			Ticking = null;
			MutiploDe10 = null;
			FinCuenta = null;
		}
	}

	class InicioEventos
	{
		Contador relojito;

		public InicioEventos()
		{
			relojito = new Contador ();

			// Antes de la suscripción al evento, necesitamos
			Console.WriteLine ("Antes de suscribirnos...");
			relojito.Inicio ();

			// Suscripcion al evento
			Console.WriteLine ("¡Suscripcion!");
			relojito.Ticking += Relojito_Ticking;
			relojito.MutiploDe10 += Relojito_MultiploDeDiez;
			relojito.FinCuenta += Relojito_FinCuenta;
			relojito.Inicio ();
		}

		void Relojito_FinCuenta (object sender, EventArgs e)
		{
			Console.WriteLine ("\n\nThis is, my friend, the end... (8)");	
		}

		void Relojito_MultiploDeDiez (object sender, EventArgs e)
		{
			Console.Write (":D ");
		}

		/// <summary>
		/// Método generado por la suscripción al evento, en el constructor de PuntoDeArranque.C
		/// Se ejecuta cada vez que se lance el evento Ticking en la Clase Reloj
		/// </summary>
		void Relojito_Ticking (int t)
		{
			Console.WriteLine ("Tick! {0} es multiplo de 100... o algo así...", t);
		}

		public static void Main (string[] args)
		{
			Console.Title = "Practica Eventos";

			InicioEventos iE = new InicioEventos ();

			Console.ReadLine ();
		}
	}
}
