using System;
using System.IO;

namespace egb.usoPath
{
    class Inicio
    {
        static void Main()
        {
            Console.Title = "Operando con Clase Path";

            char separador = Path.DirectorySeparatorChar;
            string ruta = "C:" + separador +
                "carpetilla" + separador + "ficherito.txt";

            Console.WriteLine("RUTA: " + ruta);
            Console.WriteLine("\nOTROS DATOS:");
            Console.WriteLine("NOMBRE DE FICHERO: " + Path.GetFileName(ruta)); ;
            Console.WriteLine("EXTENSION: " + Path.GetExtension(ruta));
            Console.WriteLine("NOMBRE DE FICHERO SIN EXTENSION: " + Path.GetFileNameWithoutExtension(ruta));
            Console.WriteLine("RUTA DIRECTORIO: " + Path.GetDirectoryName(ruta));
            Console.WriteLine("DIR RAIZ: " + Path.GetPathRoot(ruta));

            string ruta2 = @"C:\mio\datos\fic.dat";
            Console.WriteLine("\nRUTA: " + ruta2);
            Console.WriteLine("\nOTROS DATOS:");
            Console.WriteLine("NOMBRE DE FICHERO: " + Path.GetFileName(ruta2)); ;
            Console.WriteLine("EXTENSION: " + Path.GetExtension(ruta2));
            Console.WriteLine("NOMBRE DE FICHERO SIN EXTENSION: " + Path.GetFileNameWithoutExtension(ruta2));
            Console.WriteLine("RUTA DIRECTORIO: " + Path.GetDirectoryName(ruta2));
            Console.WriteLine("DIR RAIZ: " + Path.GetPathRoot(ruta2));

            Console.WriteLine("\n== COMBINANDO RUTAS ==");
            Console.WriteLine("RUTA ORIGEN:     " + ruta2);
            ruta2 = Path.ChangeExtension(ruta2, "egb");
            Console.WriteLine("RUTA DESTINO:    " + ruta2);

            string ruta3 = @"dir1\dir2";

            string ruta4 = Path.Combine(ruta2, ruta3);
            Console.WriteLine("NUEVA RUTA:    " + ruta4);

            Console.WriteLine("\nOTRA RUTA FICTICIA: " + Path.Combine(new string[] { "dir1", "dir2", "dir3" }));

            Console.WriteLine("\nDESDE NUESTRA RUTA ABSOLUTA \n" + Path.GetFullPath(@".\..\dir1\fi.txt"));

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();    
        }
    }
}
