using System;
using System.IO;

namespace egb.FilesYDirectories
{
    class Inicio
    {
        static void ObtenerSubdirectorios(string rutilla)
        {
            if (!Directory.Exists(rutilla))
                return;

            int contadorSubdirectorios = 0;
            DirectoryInfo[] listaSubdirectorios = new DirectoryInfo(rutilla).GetDirectories();

            Console.WriteLine("== LISTADO DE SUBDIRECTORIOS ==");
            Console.WriteLine("== LOCALIZACION: " + rutilla + " ==");
            foreach (DirectoryInfo item in listaSubdirectorios)
            {
                Console.WriteLine("[{0}] - {1}", ++contadorSubdirectorios, item.Name);
            }
            Console.WriteLine("\nFin de listado...");
        }

        static void ListarFicheros(string rutilla)
        {
            if (!Directory.Exists(rutilla))
                return;

            int contadorFicheros = 0;
            FileInfo[] listaFicheros = new DirectoryInfo(rutilla).GetFiles();

            Console.WriteLine("== LISTADO DE FICHEROS ==");
            Console.WriteLine("== LOCALIZACION: " + rutilla + " ==");
            foreach (FileInfo item in listaFicheros)
            {
                Console.WriteLine("[{0}] - {1}", ++contadorFicheros, item.Name);
            }
            Console.WriteLine("\nFin de listado...");
        }

        static void ListarFicheros(string rutilla, string ext)
        {
            if (!Directory.Exists(rutilla))
                return;

            int contadorFicheros = 0;
            FileInfo[] listaFicheros = new DirectoryInfo(rutilla).GetFiles(ext);

            Console.WriteLine("== LISTADO DE FICHEROS ==");
            Console.WriteLine("== LOCALIZACION: " + rutilla + " ==");
            foreach (FileInfo item in listaFicheros)
            {
                    Console.WriteLine("[{0}] - {1}", ++contadorFicheros, item.Name);
            }
            Console.WriteLine("\nFin de listado...");
        }

        static void CrearDirectorio(string ruta)
        {
            DirectoryInfo directorioNuevo = new DirectoryInfo(ruta);

            directorioNuevo.Create();
            Console.WriteLine("Directorio creado...");

            try
            {
                directorioNuevo.Delete();
                Console.WriteLine("Directorio borrado...");
            }
            catch
            {
                Console.WriteLine("El directorio no está vacío...");
            }
        }

        static void Main()
        {
            Console.Title = "Listando items";

            string ruta = @"C:\pruebas";
            string ruta2 = @"C:\pruebas\dir1\didasdsdr2";

            Console.WriteLine("Listando ficheros...");
            ListarFicheros(ruta);

            Console.WriteLine("\nListando ficheros con extension...");
            ListarFicheros(ruta, "*.txt");

            Console.WriteLine("\nListando subdirectorios...");
            ObtenerSubdirectorios(ruta);

            CrearDirectorio(ruta2);

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();    
        }
    }
}
