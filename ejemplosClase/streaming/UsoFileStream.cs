using System;
using System.IO;

namespace egb.UsoFileStream
{
    class Inicio
    {
        static void LeerFichero(Stream s)
        {
            int caracter;

            while ((caracter = s.ReadByte()) != -1)
            {        
                if (caracter == (int)'o')
                    Console.Write('o');
                Console.Write((char)caracter);
            }
            s.Close();
        }

        static void Main()
        {
            Console.Title = "Leyendo bytes";

            string ruta = @"C:\pruebas\datitos.txt";
            FileStream fs = new FileStream(ruta, FileMode.Open);

            LeerFichero(fs);

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();    
        }
    }
}
