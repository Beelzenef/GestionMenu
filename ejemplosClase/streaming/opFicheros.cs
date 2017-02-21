using System;
using System.IO;

namespace egb.Ficheritos
{
	class Inicio
	{
		static void Main()
		{
			string ruta1 = @"/home/usuario/Escritorio";
			string ruta2 = @"/home/usuario/Escritorio/fi.txt";

			FileInfo fi = new FileInfo (ruta2);

			if (Directory.Exists (ruta1)) {
				File.Create (ruta1);
				File.WriteAllText (ruta1, "un textito");
			}

			string[] texto = File.ReadAllText (ruta2);
			Console.WriteLine (texto);

			if (fi.Exists)
				fi.Delete ();

			Console.ReadLine ();
		}
	}
}
