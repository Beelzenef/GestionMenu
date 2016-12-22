using System;
using System.Collections;

namespace operandoStack
{
	class operandoStack
	{
		static Stack pila1 = new Stack();

		public static void Main (string[] args)
		{
			Console.Title = "Operando con stack";

			pila1.Push (1);
			pila1.Push (2);
			pila1.Push (3);

			Console.WriteLine ("En la pila hay {0} datos", pila1.Count);
			Console.WriteLine ("¿Cual es el dato en TOS? {0}", pila1.Peek());
			pila1.Pop ();
			Console.WriteLine ("¿Cual es el dato en TOS? {0}", pila1.Peek());
			pila1.Pop ();
			Console.WriteLine ("¿Cual es el dato en TOS? {0}", pila1.Peek());
			pila1.Pop ();

			try {
				Console.WriteLine ("¿Cual es el dato en TOS? {0}", pila1.Peek());
				pila1.Pop ();
			}
			catch {
				Console.WriteLine ("No hay más datos que mostrar en la pila");
			}

			Console.ReadLine ();
		}
	}
}
