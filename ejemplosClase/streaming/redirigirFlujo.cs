using System;
using System.IO;

namespace egb.RedirigirFlujos
{
    class Inicio
    {
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

        static void Main()
        {
            Console.Title = "Listando items";

            string rutaALeer = @"C:\pruebas";
            string rutaParaEscribir = @"C:\pruebas\dir1\listado.txt";

            Console.WriteLine("Este texto se muestra en pantalla");

            FileStream fs = new FileStream(rutaParaEscribir, FileMode.Create);

            // Almacenando el flujo de consola
            TextWriter flujoConsola = Console.Out;

            // Redireccionando la salida de la pantalla
            StreamWriter sw = new StreamWriter(fs);
            Console.SetOut(sw);
            ListarFicheros(rutaALeer);

            try
            {
                throw new Exception();
            }
            catch
            {
                Console.WriteLine("ERROR");
            }

            sw.Close();
            // Devolviendo a la consola su flujo natural
            Console.SetOut(flujoConsola);
            Console.WriteLine("Recuperacion de flujo");

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();    
        }
    }
}
