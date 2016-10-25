/*
    PROGRAMA: MenuFiguras
    AUTOR: Elena Guzman Blanco
    FECHA: 20/Oct/2016
    DESCRIPCION: Este programa ofrece un menú para el cálculo de areas para triangulo, cuadrado o rectángulo 
*/

using System;

namespace MenuFiguras
{
	class MenuFiguras
	{
		static void Main(string[] args)
		{
			// Variables
			ConsoleKeyInfo opcion;

			// Posiciones fijas del menú
			int col = 10;
			int fila = 5;

			// Titulo de consola
			Console.Title = "Areas de figuras";

			// Posicionando cursor
			Console.SetCursorPosition(col, fila);

			// Pintando menu
			Console.WriteLine("       Menu principal      ");
			Console.CursorLeft = col;
			Console.WriteLine ("1. Calculo de area para triangulo");
			Console.CursorLeft = col;
			Console.WriteLine ("2. Calculo de area para cuadrado");
			Console.CursorLeft = col;
			Console.WriteLine ("3. Calculo de area para rectangulo");
			Console.CursorLeft = col;
			Console.Write("¿Cual es tu opcion? ");

			opcion = Console.ReadKey ();
			Console.Clear ();
			CalcularOpcion (opcion);


			// Fin de programa
			Console.WriteLine("\n\nPulsa ENTER para salir...");
			Console.ReadLine();
		}

		static void CalcularOpcion(ConsoleKeyInfo teclita) {
		
			switch (teclita.KeyChar) {
			case '1':
				AreaTriangulo ();
				break;
			case '2':
				AreaCuadrado ();
				break;
			case '3':
				AreaRectangulo ();
				break;
			default:
				Console.WriteLine ("Tu opcion no es válida...");
				break;
			}
		}

		static void AreaTriangulo(){
			// Variables
			double area = 0;
			double baseT = 0;
			double altura = 0;

			Console.WriteLine ("\n\nBienvenidos al calculo de area de un triangulo");
			Console.Write ("¿Cual es su base? ");
			baseT = ObtenerNum (0, 100);
			Console.Write ("¿Cual es su altura? ");
			altura = ObtenerNum (0, 100);
			Console.WriteLine ("Calculando...");
			area = (baseT * altura) / 2;
			Console.WriteLine ("El area del triangulo con base {0} y altura {1} es {2}", baseT, altura, area);
		}

		static void AreaCuadrado(){
			int lado = 0;
			int area = 0;

			Console.WriteLine ("\n\nBienvenidos al calculo de area de un cuadrado");
			Console.Write ("¿Cual es su lado? ");
			lado = ObtenerNum (0, 100);
			Console.WriteLine ("Calculando...");
			area = lado * lado;
			Console.WriteLine ("El cuadrado de lado {0} es {1}", lado, area);
		}

		static void AreaRectangulo(){
			int baseR = 0;
			int altura = 0;
			int area = 0;

			Console.WriteLine ("\n\nBienvenidos al calculo de area de un rectangulo");
			Console.Write ("¿Cual es su base? ");
			baseR = ObtenerNum (0, 100);
			Console.Write ("¿Cual es su altura? ");
			altura = ObtenerNum (0, 100);
			Console.WriteLine ("Calculando...");
			area = baseR * altura;
			Console.WriteLine ("El area del rectangulo con base {0} y altura {1} es {2}", baseR, altura, area);

		}

		static int ObtenerNum()
		{
			bool valido = false;
			int num = 0;

			Console.Write("Dame un numero... ");

			while (!valido)
			{
				try
				{
					num = int.Parse(Console.ReadLine());
					valido = true;  
				}
				catch
				{
					Console.Write("Dato no valido, intentalo otra vez ");
				}
			}
			Console.WriteLine("Tu numero es válido, ¡procede!");
			return num;
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
			
	}
}
