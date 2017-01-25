using System;

/*
 * Clase Impresora que imprime por pantalla
 * Un evento llamado FinalizoOK que se lanza cuando el texto a imprimir ha terminado
 * Pasos:
 * > Crear Clase Impresora
 * > Crear campos que contienen el texto a mostrar
 * > Añadir el constructor donde se va a inicializar el contenido del texto
 * > Añadir un método para mostrar por consola el texto en cuestión
 * > Crear un evento que se disparará cuando finalice de lanzar el texto por pantalla
 * > Hacer pruebas
 */

namespace egb.AprendiendoEventos
{
	class Impresora {
		string texto;

		public event EventHandler FinalizoOK;
		public event EventHandler Iniciando;

		public void Imprimir()
		{
			if (Iniciando != null)
				Iniciando ("NOTA: Empezando a imprimir...", EventArgs.Empty);
			Console.WriteLine (texto);
			if (FinalizoOK != null)
				FinalizoOK (this, null);
		}

		public Impresora(string t)
		{
			texto = t;
		}
	}

	class InicioEventos
	{
		static string GeneraTexto()
		{
			string palabritas = "Horizon Zero Dawn lo mola todo";
			return palabritas;
		}
    
    static void Imp_Iniciando (object sender, EventArgs e)
		{
			Console.WriteLine (sender.ToString());
		}

		static void Imp_FinalizoOK (object sender, EventArgs e)
		{
			Console.WriteLine ("IMPRESION FINALIZADA");
		}

		public static void Main (string[] args)
		{
			Console.Title = "Practica Eventos";

			Impresora imp = new Impresora (GeneraTexto());
			imp.FinalizoOK += Imp_FinalizoOK;
			imp.Iniciando += Imp_Iniciando;
			imp.Imprimir ();

			Console.ReadLine ();
		}
	}
}
