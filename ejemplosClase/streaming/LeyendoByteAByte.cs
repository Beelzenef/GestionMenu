using System;
using System.IO;

namespace egb.LeyendoByteAByte
{
    class Inicio
    {
        static void MostrarBytes(FileStream fS, long posInicialLectura, long posFinalLectura)
        {
            int posEnInicio = (int)fS.Position;

            try
            {
                if (posFinalLectura > fS.Length)
                    posFinalLectura = fS.Length;
                if (posInicialLectura > posFinalLectura - 1)
                {
                    Console.WriteLine("Sobrepasado el final del fichero");
                    return;
                }
                fS.Position = posInicialLectura;

                for (long i = posInicialLectura; i < posFinalLectura; i++)
                {
                    Console.WriteLine("[{0}] - {1}", i, (char)fS.ReadByte());
                }
                fS.Position = posEnInicio;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Lectura fuera de rango...");
            }
            catch
            {
                Console.WriteLine("Se ha producido un error de lectura...");
            }
            finally
            {
                fS.Close();
            }
        }

        static void MostrarBytes(FileStream fS, long posInicialLectura)
        {
            int posEnInicio = (int)fS.Position;
            //long posAnterior = fS.Position;

            try
            {
                if (posInicialLectura > fS.Length - 1)
                {
                    Console.WriteLine("Sobrepasado el final del fichero");
                    return;
                }
                fS.Position = posInicialLectura;

                for (long i = posInicialLectura; i < fS.Length; i++)
                {
                    Console.WriteLine("[{0}] - {1}", i, (char)fS.ReadByte());
                }
                fS.Position = posEnInicio;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Lectura fuera de rango...");
            }
            catch
            {
                Console.WriteLine("Se ha producido un error de lectura...");
            }
            finally
            {
                fS.Close();
            }
        }

        static void Main()
        {
            Console.Title = "Mostrando bytes";

            string ruta = @"C:\pruebas\datitos.txt";
            long posIni = 3;
            long posFinal = 10;

            FileStream fi1 = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            FileStream fi2 = new FileStream(ruta, FileMode.Open, FileAccess.Read);

            Console.WriteLine("Leyendo hasta el final...");
            MostrarBytes(fi1, posIni);
            Console.WriteLine("\nLeyendo hasta posición determinada...");
            MostrarBytes(fi2, posIni, posFinal);

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();    
        }
    }
}
