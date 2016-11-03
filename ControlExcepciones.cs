using System;

namespace ControlExcepciones
{
	class ControlExcepciones
	{
		static void Main(string[] args)
		{
			// Variables
			int numerador = 1;
			int denominador = 1;

			// Titulo de consola
			Console.Title = "Control de excepciones";
		
			Console.WriteLine ("Divisiones incoming:\n\n");

			try {
				Console.Write ("\tDime el numerador: ");
				numerador = int.Parse (Console.ReadLine ());
				Console.Write ("\tDime el denominador: ");
				denominador = int.Parse (Console.ReadLine ());
				Console.WriteLine ("\n\t\tEl valor de {0}/{1} resulta en {2}", numerador, denominador, numerador/denominador);
			}
			catch (FormatException) {
				Console.WriteLine ("Error de formato");
			}
			catch (OverflowException) {
				Console.WriteLine ("Desbordamiento ha ocurrido");
			}
			catch (Exception e) {
				Console.WriteLine ("Excepcion " + e.ToString() + "ha ocurrido");
			}
			finally {
				Console.WriteLine ("Soy FINNALY");
			}
				

			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}

	}
}
