using System;

namespace Operadores
{
	class Operadores
	{
		static void Main(string[] args)
		{
			// Variables
			int num1 = 5;
			int resultado = 0;
			int num2 = 127;
			bool booleancillo = true;

			// Jugando con operadores
			Console.WriteLine ("Operadores de bits...");
			Console.WriteLine ("  El valor de num1 es {0}", num1);
			Console.WriteLine ("    En hexadecimal es {0:X}", num1);
			Console.WriteLine ("Su complemento a 1 es {0} y en hexa {1:X}", ~num1, ~num1);
			Console.WriteLine ("Desplazando un bit a la derecha, {0} y un bit a la izquierda, {1}", num1>>1, num1<<1);

			// Incrementos post y pre
			Console.WriteLine ("\n\nIncrementos...");
			resultado = num1++;
			Console.WriteLine ("Post: numerete = {0} y resultado = {1}", num1, resultado);
			resultado = ++num1;
			Console.WriteLine ("Pre:  numerete = {0} y resultado = {1}", num1, resultado);

			// Operadores reflexivos
			Console.WriteLine ("\n\nOperadores reflexivos...");
			Console.WriteLine ("                         El tipo int es {0}", typeof(int));
			Console.WriteLine ("                      El tipo string es {0}", typeof(string));
			Console.WriteLine ("                    El tamaño de int es {0} bytes", sizeof(int));
			Console.WriteLine ("El tipo de la variable 'numerete' es un {0}", num1.GetType());

			// Valores maximos y minimos
			Console.WriteLine ("\n\nValores minimos y maximos...");
			Console.WriteLine ("El valor minimo de un int es {0:N}", int.MinValue);
			Console.WriteLine ("El valor maximo de un int es {0:N}", int.MaxValue);
			Console.WriteLine ("El valor minimo de un uint es {0:N}", uint.MinValue);
			Console.WriteLine ("El valor maximo de un uint es {0:N}", uint.MaxValue);
			Console.WriteLine ("El valor minimo de un double es {0:E}", double.MinValue);
			Console.WriteLine ("El valor maximo de un double es {0:E}", double.MaxValue);

			// Complemento a 1
			Console.WriteLine ("\n\nComplemento a 1...");
			Console.WriteLine ("La variable 'numerillo' en decimal es {0} y en hexa es {1:X8}", num2, num2);
			Console.WriteLine ("El valor de 'booleancillo' es {0}, y su negacion es {1}", booleancillo, !booleancillo);


			// Salida
			Console.WriteLine ("\n\nPulsa ENTER para salir...");
			Console.ReadLine ();
		}
	}
}
