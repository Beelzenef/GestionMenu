using System;

namespace egb.HyP
{
	abstract class Grafico {

		public void Pinta()
		{
			Console.WriteLine ("Dibujando cosis con Clase.G");
		}

		abstract public void Punto();
	}

	class Figura : Grafico
	{
		// Campos
		int valor = 0;
		public static int ValorEstatico = 0;

		// Constructores
		public Figura(int v, int vE)
		{
			this.valor = v;
			Figura.ValorEstatico = vE;
		}

		public Figura()
		{

		}

		// Mets
		public static void UnMetodoEstatico()
		{
			Console.WriteLine ("Metodo estático Clase.F");
		}

		public override void Punto ()
		{
			Console.WriteLine ("Soy un punto, metodo sobreescrito en Clase.F");
		}

		public new void Pinta()
		{
			base.Pinta ();
			Console.WriteLine ("Dibujando cosis desde Clase.F");
		}
	}

	class DerivadaDeFigura : Figura
	{

	}

	sealed class ClaseFinal
	{
		public void Saludo()
		{
			Console.WriteLine ("Soy una Clase final");
		}
	}

	class Inicio
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Usando la herencia:");
			Figura fig1 = new Figura ();
			fig1.Punto ();
			fig1.Pinta ();
			Figura.UnMetodoEstatico ();
			DerivadaDeFigura der1 = new DerivadaDeFigura ();
			der1.Punto ();
		
			Console.WriteLine ("\nUsando el polimorfismo:");
			Grafico graf1 = new Figura ();
			Grafico graf2 = new DerivadaDeFigura ();
			graf1.Pinta ();
			graf2.Pinta ();

			Console.WriteLine ("\nUsando Clases finales:");
			ClaseFinal fin1 = new ClaseFinal ();
			fin1.Saludo ();

			Console.ReadLine ();
		}
	}

}
