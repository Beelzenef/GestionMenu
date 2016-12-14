using System;
using System.Text;

namespace meetStringBuilder
{
	class meetStringBuilder
	{
		static void InfoStringB(StringBuilder stb)
		{
			Console.WriteLine ("\n\tDATOS DEL STRINGBUILDER");
			Console.WriteLine (string.Empty.PadRight(40, '='));
			Console.WriteLine ("Contenido \t\t{0}", stb);
			Console.WriteLine ("Longitud \t\t{0}", stb.Length);
			Console.WriteLine ("Capacidad \t\t{0}", stb.Capacity);
			Console.WriteLine ("Capacidad maxima \t{0}", stb.MaxCapacity);
		}

		static void MostrarStringB(StringBuilder stb)
		{
			Console.WriteLine ("\n\n\tMOSTRANDO STRINGBUILDER");
			Console.WriteLine (string.Empty.PadRight(40, '='));
			for (int i = 0; i < stb.Length; i++)
				Console.Write (stb[i]);
		}

		static void MostrarDiffStringB(StringBuilder stb)
		{
			Console.WriteLine ("\n\n\tMODIFICANDO STRINGBUILDER");
			Console.WriteLine (string.Empty.PadRight(40, '='));
			for (int i = 0; i < stb.Length; i++) {
				if (stb [i] == 'e')
					Console.Write ('#');
				else
					Console.Write (stb [i]);
			}
		}

		static void ConstruirString(int longitud)
		{
			DateTime entrada = DateTime.Now;

			string s = string.Empty;
			for (int i = 0; i < longitud; i++)
				s += "@";

			TimeSpan tiempo = DateTime.Now - entrada; 
			Console.WriteLine ("Construccion de string, {0} milisegundos", tiempo.Milliseconds);
		}

		static void ConstruirStringB(int longitud)
		{
			DateTime entrada = DateTime.Now;

			StringBuilder s = new StringBuilder ();
			for (int i = 0; i < longitud; i++)
				s.Append ("@");

			TimeSpan tiempo = DateTime.Now - entrada;
			Console.WriteLine ("Construccion de StringBuilder, {0} milisegundos", tiempo.Milliseconds);
		}

		public static void Main (string[] args)
		{
			Console.Title = "meet Stringbuilder";

			int limite = 100000;

			StringBuilder strb1 = new StringBuilder ();
			StringBuilder strb2 = new StringBuilder (1000);
			StringBuilder strb3 = new StringBuilder ("hey there");
			StringBuilder strb4 = new StringBuilder ("hey there", 0, 3, 3);

			InfoStringB (strb3);
			InfoStringB (strb4);
			strb4.Append (" " + strb3);
			InfoStringB (strb4);
			strb4[5] = '@';
			InfoStringB (strb4);

			MostrarStringB (strb4);
			MostrarDiffStringB (strb4);
			Console.WriteLine ();
			strb4.Append ('!', 10);
			InfoStringB (strb4);
			Console.WriteLine ();
			ConstruirString (limite);
			ConstruirStringB (limite);

			Console.ReadLine ();
		}
	}
}
