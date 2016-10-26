using System;
using System.Threading;

namespace ConversionBinario
{
	class Inicio
	{
		static void Main(string[] args)
		{
			// Variables

			// Titulo de consola
			Console.Title = "Conversion a binario";

			Console.WriteLine (generarFecha (1999, 2011).ToLongDateString ());
			Console.WriteLine (generarFecha().ToLongDateString());
			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();

		}
		
		static string ConversorABinario()
		{
			// Variables
			string convertido = string.Empty;
			int mascara = 1;
			int resultadoAND = 0;
			int numero = 0;

			Console.WriteLine ("Dame un numero para convertir a binario:");
			numero = ObtenerNum (0, 20);

			Console.WriteLine ("Calculando...");

			for (int i = 0; i < 8; i++) {
				mascara = mascara * mascara;
				resultadoAND = numero & mascara;

				if (resultadoAND == 0)
					convertido = "1" + convertido;
				else
					convertido= "0" + convertido;
			}

			Console.WriteLine ("Tu número {0} es, en binario, {1}", numero, convertido);
			return convertido;
		}

		static int ObtenerNum(int min, int max)
		{
			bool valido = false;
			int num = 0;

			Console.Write("Dame un numero... ");

			while (!valido)
			{
				try
				{
					num = int.Parse(Console.ReadLine());
					if (num >= min && num <= max)
						valido = true;
					else
						Console.WriteLine("Tu numero no es válido, inténtalo otra vez ");
				}
				catch
				{
					Console.Write("Dato no valido, intentalo otra vez ");
				}
			}
			Console.WriteLine("Tu numero es válido, ¡procede!");
			return num;
		}

		static DateTime generarFecha()
		{
			int dia = 0;
			int mes = 0;
			int anio = 0;
			Random dado = new Random ();

			anio = dado.Next (1990, 2017);
			mes = dado.Next (1, 13);
			dia = dado.Next (1, DateTime.DaysInMonth(anio, mes) + 1);

			DateTime fechaNueva = new DateTime (anio, mes, dia);
			return fechaNueva;

		}


		static DateTime generarFecha(int anioIni, int anioFin)
		{
			// Generar una fecha aleatoria CORRECTA entre los dos años pasados
			Random dado = new Random();

			// Variables para dias, meses y años
			int anio = 0;
			int mes = 0;
			int dia = 0;

			anio =  dado.Next (anioIni, anioFin + 1);
			mes = dado.Next (1, 13);

			// Calculando dias para el mes...
			switch (mes) {
			case 1:
			case 3:
			case 5:
			case 7:
			case 8:
			case 10:
			case 12:
				dia = dado.Next (1, 32);
				break;
			case 4:
			case 11:
			case 9:
			case 6:
				dia = dado.Next (1, 31);
				break;
			default:
				dia = esBisiesto(anio) ? dado.Next(1,30) : dia = dado.Next (1, 29);
				break;
			}

			DateTime fechaResultado = new DateTime (anio, mes, dia);
			return fechaResultado;
		}

		static bool esBisiesto(int anio)
		{
			bool bisiestoONo = false;

			if (anio % 4 == 0) {
				if (anio % 100 == 0) {
					if (anio % 400 == 0) {
						bisiestoONo = true;
					}
					else {
						bisiestoONo = false;
					}
				} else {
					bisiestoONo = true;
				}
			} else {
				bisiestoONo = false;
			}
			
			return bisiestoONo;
		}
	}
}
