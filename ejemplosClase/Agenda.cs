using System;
using System.Collections.Generic;

namespace egb.AgendaYOtrasCosis
{
	class Agenda
	{
		List<Anotacion> listilla = new List<Anotacion>();

		public void AnadirAnotacion()
		{
			listilla.Add (new Anotacion (DateTime.Now, "SIGUE CON EL TUTORIAL DE UNITY", "tlfInstructor"));
		}

		public void AnadirAnotacionVacia()
		{
			listilla.Add (new Anotacion ());
		}

		public void VerAnotaciones()
		{
			foreach (Anotacion item in listilla) {
				Console.WriteLine (item);
			}
		}

		class Anotacion
		{
			// Campos
			DateTime fecha;
			string texto;
			string tlf;

			#region Props
			public string TextoAnotacion
			{
				get { return this.texto; }
				set { this.texto = value; }
			}

			public string Telefono
			{
				get { return this.tlf; }
				set { this.tlf = value; }
			}

			public DateTime Fecha
			{
				get { return this.fecha; }
				set { this.fecha = value; }
			}

			#endregion

			public override string ToString ()
			{
				return string.Format ("[Anotacion: \n\tTexto={0}, \n\tTelefono={1}, \n\tFecha={2}]", TextoAnotacion, Telefono, Fecha.ToShortDateString());
			}

			// Constructores

			static Anotacion () 
			{
				Console.WriteLine ("Constructor vacío estático de Clase.Anotacion");
			}

			public Anotacion ()
			{
			
				Console.WriteLine ("Constructor vacío de Clase.Anotacion");
			}

			public Anotacion (DateTime f, string txt, string t)
			{
				this.fecha = f;
				this.texto = txt;
				this.tlf = t;

				Console.WriteLine ("Un constructor con parámetros de Clase.Anotacion");
			}

			~Anotacion ()
			{
				Console.WriteLine ("Destructor de Clase.Anotacion (pero no de planetas...)");
			}
		}
	}

	class Inicio
	{
		public static void Main (string[] args)
		{
			Console.Title = "Clase Agenda";

			Agenda unaAgenda = new Agenda ();

			unaAgenda.AnadirAnotacion ();
			unaAgenda.AnadirAnotacion ();
			unaAgenda.VerAnotaciones ();

			unaAgenda.AnadirAnotacionVacia ();

			Console.ReadLine ();
		}
	}
}