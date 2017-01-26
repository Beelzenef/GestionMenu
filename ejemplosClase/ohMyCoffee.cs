using System;

namespace egb.Cafetitos
{
	class Cafeteria
	{
		int cafes = 0;

		public int Cafes
		{
			get { return cafes; }
		}

		public event EventHandler NoMasCafe;
		public event EventHandler CafePreparado;

		public void AnadirCafe()
		{
			if (CafePreparado != null)
				CafePreparado (this, null);
			cafes++;
		}

		public void Anadir5Cafes()
		{
			if (CafePreparado != null)
				CafePreparado (this, null);
			cafes += 5;
		}

		public void ServirCafe()
		{
			if (NoMasCafe != null && Cafes == 0) {
				NoMasCafe ("SOCORRO NO QUEDA CAFÉ", null);
				return;
			}
			Console.WriteLine ("Café servido... Queda(n) {0}", Cafes);
			cafes--;
		}

		public Cafeteria()
		{
			cafes = 2;
		}
	}

	class Inicio
	{
		static void Cafetitos_NoMasCafe (object sender, EventArgs e)
		{
			Console.WriteLine (sender.ToString());
		}

		static void Cafetitos_CafePreparado (object sender, EventArgs e)
		{
			Console.WriteLine ("Preparando más café...");

		}

		static void Main (string[] args)
		{
			Console.Title = "Cafeteria OhMyEvent!";

			Cafeteria cafetitos = new Cafeteria ();
			cafetitos.CafePreparado += Cafetitos_CafePreparado;
			cafetitos.NoMasCafe += Cafetitos_NoMasCafe;

			for (int i = 0; i < 3; i++) {
				cafetitos.ServirCafe ();
			}
			cafetitos.Anadir5Cafes ();
			cafetitos.ServirCafe ();

			Console.ReadLine ();
		}
	}
}
