using System;

namespace egb.Circunferencia
{
	class Circunferencia
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

		public double Area {
			get {
				this.area = Math.PI * Math.Pow (this.radio, 2);
				return this.area;
			}
		}

		public double Longitud {
			get {
				this.longitud = 2 * Math.PI * this.radio;
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
	}

	class Inicio
	{
		public static void Main (string[] args)
		{
			Console.Title = "Clase Circunferencia";

			Circunferencia c1 = new Circunferencia ();
			Circunferencia c2 = new Circunferencia (12);

			Console.WriteLine ("C1: " + c1.ToString());
			Console.WriteLine ("C2: " + c2.ToString());
			Console.WriteLine ("Cambiando a C1...");
			c1.Radio = 105;
			Console.WriteLine ("C1: " + c1.ToString());

			Console.ReadLine ();
		}
	}
}
