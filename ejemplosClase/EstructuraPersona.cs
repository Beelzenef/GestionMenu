using System;

namespace EstructuraPersona
{
	class EstructuraPersona
	{
		struct FichaPersona {
		
			// Campos
			private string nombre;
			float altura;
			int edad;

			// Constructores
			public FichaPersona(string n, float a, int e)
			{
				nombre = n;

				if (e > 120)
					e = 120;
				if (e < 18)
					e = 18;
				edad = e;

				if (a > 2.30F)
					a = 2.30F;
				altura = a;
			}

			// Metodos de asignacion y recuperación de datos
			public string getNombre() {
				return nombre;
			}

			public void setNombre(string n) {
				nombre = n;
			}

			public float getAltura() {
				return altura;
			}

			public float setAltura(float a) {

				if (a > 2.30F)
					a = 2.30F;
				if (a < 1F)
					a = 1F;
				altura = a;
				return a;
			}

			public int getEdad() {
				return edad;
			}

			public int setEdad(int e) {

				if (e > 120)
					e = 120;
				if (e < 18)
					e = 18;
				edad = e;
				return e;
			}

			public string getPersona() {
				return nombre + ", " + edad.ToString() + ", " + altura.ToString();
			}

			public override string ToString ()
			{
				return string.Format ("Nombre: {0}; edad: {1}; altura: {2};", nombre, edad, altura);
			}
		}

		static void Main(string[] args)
		{

			FichaPersona p1 = new FichaPersona ("Atreides", 1.93F, 300);
			FichaPersona p2 = new FichaPersona ("Eragon", 1.93F, 300);
			FichaPersona p3 = new FichaPersona ("Colophonius", 2.80F, 300);
			FichaPersona p4 = new FichaPersona ("Jace", 1.93F, 300);
			FichaPersona p5 = new FichaPersona ("Church", 1.93F, 300);
			FichaPersona p6 = new FichaPersona ("Jillian", 1.93F, 300);

			// Método getPersona() vs ToString()
			Console.WriteLine ("Escribe datos de P3: " + p3.getPersona());
			Console.WriteLine (p3.ToString());

			// Volcando datos de p6 sobre p8
			FichaPersona p8 = new FichaPersona ();
			p8 = p6;
			Console.WriteLine (p8.ToString ());

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}
	}
}
