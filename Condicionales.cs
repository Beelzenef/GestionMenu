using System;

namespace Condicionales
{
	class Condicionales
	{
		static void Main(string[] args)
		{
			// Variables
			int numLeido = 0;
			int numAleatorio = 0;

			Random dado = new Random ();

			// Titulo de consola
			Console.Title = "Condicionales y menuses";

			// Jugando con condicionales de dos caminos
			numAleatorio = dado.Next (101);
			Console.WriteLine (numAleatorio);

			Console.Write ("Dime tu numero: ");
			try {
			numLeido = int.Parse(Console.ReadLine());
			}
			catch {}

			if (numAleatorio > numLeido)
				Console.WriteLine ("El numero aleatorio {0} es mayor que el numero leido {1}", numAleatorio, numLeido);
			else
				Console.WriteLine ("Prueba otra vez...");

			Console.ReadLine ();
			// Jugando con switch
			// Menu en consola

			char opcion = ' ';

			Console.Clear ();
			// Dibujando menu
			Console.WriteLine ("M E N U  P R I N C I P A L");
			Console.WriteLine ("==========================");
			Console.WriteLine ("1. Altas");
			Console.WriteLine ("2. Bajas");
			Console.WriteLine ("3. Consultas");
			Console.WriteLine ("\t\t0. Salir");
			Console.Write ("¿Qué deseas hacer? ");

			try {
			opcion = char.Parse (Console.ReadLine ());
			}
			catch {}

			switch (opcion) {
			case '1':
				Console.WriteLine ("¡Dando de alta a un usuario!");
				break;
			case '2':
				Console.WriteLine ("¿Bajas? ¡Estás despedido!");
				break;
			case '3':
				Console.WriteLine ("Datos, ¡DATOS!, la información es poder...");
				break;
			case '0':
				Console.WriteLine ("Saliendo del programa, ¡a la calle!");
				break;
			// Otras opciones, anidando en ORs
			case '5':
			case '6':
			case '7':
				Console.WriteLine ("Tu opcion es 5, 6 o 7");
				break;
			default:
				Console.WriteLine ("ERROR: Opcion no valida");
				break;
			}

			Console.ReadLine ();

			// Operador ternario

			Console.Clear();
			string resultado = string.Empty;
			int num = 0;

			Console.WriteLine ("Dime un numero y te diré si es par");

			try {
				num = int.Parse(Console.ReadLine());
			}
			catch {}

			resultado = (num % 2 == 0) ? "par" : "impar";

			Console.WriteLine ("Tu numero es {0}", resultado);
			
			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();
		}
	}
}
