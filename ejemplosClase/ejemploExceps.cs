using System;

namespace egb.progExcepciones
{
	class ExcPropiaException : Exception {	}

	class Clase1
	{
		public static void M1()
		{
			try {
				Console.WriteLine ("Clase1.M1(); - tryOverflowException");
				Clase2.M2();
			}
			catch (OverflowException e1)
			{
				Console.WriteLine ("Clase1.M1(); - catchOverflowException");
			}
			catch (Exception e2)
			{
				Console.WriteLine ("Clase1.M1(); - catchGenerico");
			}
			finally {
				Console.WriteLine ("Clase1.M1(); - FINALLY");
			}
		}
	}

	class Clase2
	{
		public static void M2()
		{
			try
			{
				Console.WriteLine ("Clase2.M2(); - tryOverflowException");
				throw new ExcPropiaException();
				Console.WriteLine ("Esta línea nunca verá la luz :(");
			}
			catch (OverflowException e1)
			{
				Console.WriteLine ("Clase2.M2(); - catchOverflowException");
			}
			catch (Exception e2)
			{
				Console.WriteLine ("Clase2.M2(); - catchGenerico");
			}
			finally {
				Console.WriteLine ("Clase2.M2(); - FINALLY");
			}
		}
	}

	class Inicio
	{
		static void Main()
		{

			try {
				Console.WriteLine ("TRY en Main");
				Clase1.M1();
				return;
			}
			catch (ExcPropiaException ex)
			{
				Console.WriteLine ("CATCH de mi propia Excepcion");
			}
			catch (Exception ex)
			{
				Console.WriteLine ("CATCH en Main");
			}
			finally {
				Console.WriteLine ("FINALLY en Main");
			}

			Console.ReadLine ();
		}
	}
}
