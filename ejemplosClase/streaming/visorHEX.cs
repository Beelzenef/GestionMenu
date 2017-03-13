using System;
using System.IO;

namespace egb.VisorHex
{
    class Inicio
    {
        static void MostrarInfo(FileInfo fi)
        {
            Console.WriteLine();
            Console.WriteLine("     Nombre: {0}", fi.Name);
            Console.WriteLine("     Tamaño: {0}", fi.Length);
        }

        static void VerHex(FileInfo fi)
        {
            using (FileStream lector = fi.OpenRead())
            {
                if (fi.Length == 0)
                {
                    Console.WriteLine("Fichero vacío");
                    return;
                }

                byte[] almacenBytes = new byte[16];
                long nBytesLeidos = lector.Read(almacenBytes, 0, 16);

                while (nBytesLeidos != 0)
                {
                    // Mosrar posiciones de lectura
                    Console.Write("\n {0:X8}:", lector.Position - 16);

                    // Mostrar linea de contneido en bytes
                    for (int i = 0; i < nBytesLeidos; i++)
                    {
                        Console.Write(" {0:X2}", almacenBytes[i]);
                    }

                    // Mostrar el caracter del byte sino un punto
                    for (int i = 0; i < 16 - nBytesLeidos; i++)
                        Console.Write("   ");
                    Console.Write(" | ");

                    // Mostrar los caracteres correspondientes o un punto
                    for (int i = 0; i < nBytesLeidos; i++)
                    {
                        char carActual = (char)almacenBytes[i];
                        if (Char.IsControl(carActual))
                            Console.Write(".");
                        else
                            Console.Write(carActual);
                    }
                    nBytesLeidos = lector.Read(almacenBytes, 0, 16);
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Mostrando bytes";

            string ruta = string.Empty;

            if (args.Length != 1)
            {
                Console.WriteLine("ERROR: Parámetros incorrectos");
                Console.ReadLine();
                return;
            }
            if (!File.Exists(args[0]))
                return;

            ruta = args[0];
            Console.WriteLine("¡Leyendo fichero!");
            FileInfo fichero = new FileInfo(ruta);

            MostrarInfo(fichero);
            VerHex(fichero);

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();    
        }
    }
}
