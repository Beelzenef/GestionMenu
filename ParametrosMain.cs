using System;

namespace ParametrosMain
{
    class ParametrosMain
    {
        static void Main(string[] args)
        {
            // Variables
            int numeroRecibido = 0;

            // Titulo de consola
            Console.Title = "Visitando parametros de Main";

            // Simulando llamada de aplicacion:
                    // C:> nombreAplicacion texto numero
            // Mostrando el texto las veces que indique el numero

            if (args.Length < 2)
            {
                Console.WriteLine("Faltan parámetros");
                Console.ReadLine();
                return;
            }
            if (args.Length > 2)
            {
                Console.WriteLine("Demasiados parámetros");
                Console.ReadLine();
                return;
            }

            try
            {
                numeroRecibido = int.Parse(args[1]);
                for (int i = 0; i < numeroRecibido; i++)
                    Console.WriteLine(args[0]);
            }
            catch
            {
                Console.WriteLine("El segundo parámetro no es un numero entero...");
                Console.ReadLine();
            }
        }
    }
}