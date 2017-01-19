using System;
using System.Collections.Generic;

namespace egb.Circunferencia
{
	abstract class Figura
	{
		public abstract double Area {
			get;
		}

		public abstract double Longitud {
			get;
		}

		public virtual ConsoleColor Color()
		{
			return ConsoleColor.Red;
		}
	}

	class Circunferencia : Figura
	{
		// Campos
		double radio = 0;
		double area = 0;
		double longitud = 0;

		// Props
		public double Radio {
			get { return this.radio; }
			set {
				if (value < 0)
					value = 0;
				if (value > 100)
					value = 100;
				this.radio = value;
			}
		}

		override public double Area {
			get {
				this.area = Math.PI * Math.Pow (radio, 2);
				return this.area;
			}
		}

		override public double Longitud {
			get {
				this.longitud = 2 * Math.PI * radio;
				return this.longitud;
			}
		}

		// Constructores
		public Circunferencia()
		{
			radio = 0;
			area = 0;
			longitud = 0;
		}

		public Circunferencia(double r)
		{
			Radio = r;
		}

		public override string ToString ()
		{
			return string.Format ("[Radio {0}, Area {1}, Longitud {2}]",
				this.Radio.ToString(), this.Area.ToString(), this.Longitud.ToString());
		}

		public override ConsoleColor Color ()
		{
			return ConsoleColor.Blue;
		}
	}

	class Cuadrado : Figura
	{
		double lado;
		double longitud;
		double area;

		public double Lado {
			get {
				return this.lado;
			}
			set { 
				if (value < 0)
					value = 0;
				if (value > 100)
					value = 100;
				this.lado = value;

				this.area = Math.Pow (lado, 2);
				this.longitud = lado * 4;
			}
		}

		public override double Area {
			get {
				return this.area;
			}
		}

		public override double Longitud {
			get {
				return this.longitud;
			}
		}

		public Cuadrado(double l)
		{
			lado = l;
			area = lado * lado;
			longitud = lado * 4;
		}

		public override string ToString ()
		{
			return string.Format ("[Lado {0:D3}, Area {1:D3}, Longitud {2:D3}]", Lado, Area, Longitud);
		}
	}

	class Triangulo
	{
		public double Base { get; set; } = 100;
		public double Area { get; set; }
		public double Perimetro { get; set; }

		public Triangulo() { }

		public Triangulo(double b)
		{
			Base = b;
		}

		public override string ToString ()
		{
			return string.Format ("[Triangulo: Base {0}]", Base);
		}
	}

	class Inicio
	{
		public static void Main (string[] args)
		{
			Console.Title = "Clase Circunferencia";

			Circunferencia cir1 = new Circunferencia ();
			Circunferencia cir2 = new Circunferencia (12);

			Console.WriteLine ("Cir1: " + cir1.ToString());
			Console.WriteLine ("Cir2: " + cir2.ToString());
			Console.WriteLine ("Cambiando Cir1...");
			cir1.Radio = 105;
			Console.WriteLine ("Cir1: " + cir1.ToString());

			Cuadrado cu1 = new Cuadrado (5.5);
			Console.WriteLine ("Cu1: " + cu1.ToString());

			Triangulo t1 = new Triangulo (5);
			Triangulo t2 = new Triangulo ();
			Console.WriteLine ("T1: " + t1.ToString());
			Console.WriteLine ("T2: " + t2.ToString());

			Console.ReadLine ();
		}
	}
}
