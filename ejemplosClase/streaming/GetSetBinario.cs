using System;
using System.IO;
using System.Text;

namespace egb.GetSetBinario
{
    class Inicio
    {
        static void Main(string[] args)
        {
            // Titulo
            Console.Title = "Leyendo y escribiendo en binario";

            string ruta = @"C:\pruebas\file_binario.dat";
            string texto = string.Empty;

            // Escribiendo en binario
            FileStream flujoEscritura = new FileStream(ruta, FileMode.Create, FileAccess.Write);
            BinaryWriter escritor = new BinaryWriter(flujoEscritura, Encoding.Default);
           
            escritor.Write("Elena");
            escritor.Write(23);
            escritor.Write(true);

            escritor.Close();

            // Leyendo en binario
            FileStream flujoLectura = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader lector = new BinaryReader(flujoLectura, Encoding.Default);

            texto = lector.ReadString() + " " + lector.ReadInt16().ToString() + " " + lector.ReadBoolean().ToString();
            Console.WriteLine(texto);

            lector.Close();

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
