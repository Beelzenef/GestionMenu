using System;
using System.IO;

namespace egb.usoDirectoryInfo
{
    class Inicio
    {
        static void Main()
        {
            Console.Title = "Informacion con DirectoryInfo";

            string ruta = @"C:\pruebas";
            DirectoryInfo di = new DirectoryInfo(ruta);

            DirectoryInfo[] listaDirectorios = di.GetDirectories();

            foreach (DirectoryInfo item in listaDirectorios)
            {
                Console.WriteLine("\nUn directorio...");
                Console.WriteLine("Ruta absoluta: " + item.FullName);
                Console.WriteLine("Fecha de creacion: " + item.CreationTime.ToShortDateString());
                Console.WriteLine("Directorio padre: " + item.Parent);
            }

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();    
        }
    }
}
