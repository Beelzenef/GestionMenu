using System;

namespace egb.oop
{
	class Inicio
	{
		public static void Main (string[] args)
		{
			Clase2 unaClase = new Clase2 ();

			unaClase.MetodoPublico ();
			unaClase.OtroMetodoPublico ();

			Console.ReadLine ();
		}
	}

	class Clase1
	{
		public void MetodoPublico()
		{

		}

		protected static void MetodoProtegido()
		{

		}

		private void MetodoPrivado()
		{

		}
	}

	class Clase2 : Clase1
	{
		public void OtroMetodoPublico()
		{
			Clase1.MetodoProtegido ();
		}
	}
}
