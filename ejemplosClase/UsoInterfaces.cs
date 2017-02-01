using System;

namespace egb.Interfaces
{
	public delegate void Anotacion (string s);
	interface IPrueba
	{
		string Anotacion { get; set; }
		void Mostrar();
		string this [int index] { get; }
		event Anotacion Anadida;
	}

	class Agenda : OtraClase, IPrueba
	{
		string nota;

		public string Anotacion { get { return nota; } set { nota = value; } }

		public void Mostrar()
		{
			Console.WriteLine ("LOL");
		}
		public string this [int index] { get { throw new NotImplementedException (); } }

		public event Anotacion Anadida;
	}

	class OtraClase
	{
		public void Ver()
		{

		}
	}

	class Inicio
	{
		static void Main()
		{
			Console.ReadLine ();
		}
	}

}