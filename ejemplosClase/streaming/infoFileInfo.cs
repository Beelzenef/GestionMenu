using System;
using System.IO;

namespace egb.usoFileInfo
{
    class Inicio
    {
        static void MostrarInfoFichero(FileInfo f)
        {
            if (!f.Exists)
                return;

            Console.WriteLine("== INFORMACION DEL FICHERO ==\n");
            Console.WriteLine("Ruta completa: " + f.FullName);
            Console.WriteLine("Nombre de fichero: " + f.Name);
            Console.WriteLine("¿En qué directorio está? " + f.DirectoryName);
            Console.WriteLine("Tamaño en bytes: " + f.Length);
            Console.WriteLine("¿Es de solo lectura? " + f.IsReadOnly);
            Console.WriteLine("Día de creación: " + f.CreationTime.ToShortDateString());
            Console.WriteLine("Extensión del fichero: " + f.Extension);
            Console.WriteLine("¿Cuando se abrió por última vez? " + f.LastAccessTime.ToShortDateString());
            Console.WriteLine("Atributos: " + f.Attributes.ToString());
        }

        static void OcultarFichero(FileInfo f)
        {
            if (!f.Exists)
                return;

            f.Attributes = FileAttributes.Hidden;
        }

        static void CambiarMomentoCrecion(FileInfo f)
        {
            if (!f.Exists)
                return;

            f.CreationTime = DateTime.Now;
        }

        static void Main()
        {
            Console.Title = "Informacion con FileInfo";

            string ruta = @"C:\pruebas\fichero.txt";

            try
            {
                FileInfo fi = new FileInfo(ruta);
                MostrarInfoFichero(fi);
                OcultarFichero(fi);
                CambiarMomentoCrecion(fi);
                MostrarInfoFichero(fi);
            }
            catch (Exception e)
            {
                Console.WriteLine("Fichero no encontrado...");
            }

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();    
        }
    }
}
