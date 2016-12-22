using System;

namespace ClasePila
{
	class ClasePila
	{
		public static void Main (string[] args)
		{
			Pila p1 = new Pila (2);

			p1.Meter (1);
			p1.Meter (2);
			p1.Meter (3);
			p1.Meter (4);

			Console.WriteLine ("En la pila hay {0} elementos", p1.Contar);

			p1.Mostrar (true);
			Console.WriteLine ("¿Cual es el dato en TOS? {0}", p1.Mirar());
			p1.Sacar ();
			Console.WriteLine ("¿Cual es el dato en TOS? {0}", p1.Mirar());
			p1.Sacar ();
			Console.WriteLine ("¿Cual es el dato en TOS? {0}", p1.Mirar());
			p1.Sacar ();

			Console.WriteLine ("En la pila hay {0} elementos", p1.Contar);

			try {
				Console.WriteLine ("¿Cual es el dato en TOS? {0}", p1.Mirar());
				p1.Sacar ();
			} catch {
				Console.WriteLine ("LOLNOPE");
			}

			Console.ReadLine ();

		}
	}

	class Pila {

		#region Campos

		private object[] _pila;
		private int _nDatos;

		#endregion

		#region Propiedades

		public int Contar {
			get { return _nDatos; }
		}

		public int Capacidad {
			get { return _pila.Length; }
		}

		#endregion

		#region Metodos

		public void Meter(object dato)
		{
			if (_nDatos == _pila.Length)
				AmpliarPila ();
			_pila [_nDatos++] = dato;
		}

		public object Sacar()
		{
			return _pila [--_nDatos];
		}

		public object Mirar()
		{
			return _pila [_nDatos - 1];
		}

		public void Mostrar(bool espera)
		{
			for (int i = _nDatos - 1; i >= 0; i--)
				Console.WriteLine (_pila[i].ToString());
			if (espera)
				Console.ReadLine ();
		}

		#region Metodos privados

		private void AmpliarPila()
		{
			const int ampliacionCapacidad = 16;
			object[] _pilaTMP = new object[_pila.Length + ampliacionCapacidad];
			// Copia de datos
			_pila.CopyTo (_pilaTMP, 0);

			_pila = _pilaTMP;
		}

		#endregion

		#endregion

		#region Constructores

		public Pila()
		{
			_pila = new object[16];
			_nDatos = 0;
		}

		public Pila(int capacidadInicial)
		{
			_pila = new object[capacidadInicial];
			_nDatos = 0;
		}

		public Pila(object[] datos)
		{
			_pila = datos;
			_nDatos = datos.Length;
		}

		#endregion

	}
}
