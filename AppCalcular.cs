using System;

namespace Calcular
{
    /// <summary>
    /// App de consola:
    ///     - La longitud de una circunferencia
    ///     - El volumen de un cilindro
    ///     - El area de un círculo
    /// Los parámetros se pasan desde consola
    /// </summary>
    class Calcular
    {
        static void Main(string[] args)
        {
            int nParametros = args.Length;
            double radio = 0;
            double altura = 0;

            Console.Clear();

            // Si no especificas parametros o mas de los permitidos...
            if (nParametros == 0 || nParametros > 3)
            {
                MasInfo(nParametros);
                Ayuda();
            }
            // ¿Estás solicitando ayuda?
            if (nParametros == 1)
            {
                if (args[0] != "?")
                {
                    Console.WriteLine("Parametro desconocido");
                    Console.ReadLine();
                    return;
                }
                Ayuda();
            }
            // Dos parámetros, ¿calculando longitud o area?
            if (nParametros == 2)
            {
                try
                {
                    radio = double.Parse(args[1]);

                    if (args[0].ToLower() == "l")
                        Console.WriteLine("La longitud de la circunferencia de radio {0} es {1}", radio, Longitud(radio));
                    if (args[0].ToLower() == "a")
                        Console.WriteLine("El area de la circunferencia de radio {0} es {1}", radio, Area(radio));
                }
                catch
                {
                    Console.WriteLine("ERROR: parametro radio no es un entero. Puedes invocar la ayuda con '?'");
                    Ayuda();
                }
            }
            // Tres parametros, una letra y dos numeros
            if (nParametros == 3)
            {
                try
                {
                    radio = double.Parse(args[1]);
                    altura = double.Parse(args[2]);

                    if (args[0] == "v")
                        Console.WriteLine("El volumen de radio {0} y altura {1} es {2}", radio, altura, Volumen(radio, altura));
                }
                catch
                {
                    Console.WriteLine("ERROR: parametros incorrectos. Puedes invocar la ayuda con '?'");
                    Ayuda();
                }
            }

            // Fin de programa
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();

        }

        #region Calculos

        static double Longitud(double radio)
        {
            return 2 * Math.PI * radio;
        }

        static double Area(double radio)
        {
            return Math.PI * radio * radio;
        }

        static double Volumen(double radio, double altura)
        {
            return Math.PI * radio * radio * altura;
        }

        #endregion

        #region Ayudas

        static void Ayuda()
        {
            Console.WriteLine("======================================================================");
            Console.WriteLine("  Instrucciones para App Calcular");
            Console.WriteLine("    Parametros a recibir:");
            Console.WriteLine("      - Un número entero");
            Console.WriteLine("      - Una letra, a saber:");
            Console.WriteLine("            A/a:");
            Console.WriteLine("            L/l");
            Console.WriteLine("            V/v");
            Console.WriteLine("    Posibles sintaxis:");
            Console.WriteLine("       Calcular [l/L] radio        -- Para calcular la longitud");
            Console.WriteLine("       Calcular [a/A] radio        -- Para calcular el area");
            Console.WriteLine("       Calcular [v/V] radio altura -- Para calcular el volumen");
            Console.WriteLine("       Calcular ?                  -- Para mostrar esta ayuda");
            Console.WriteLine("======================================================================");
        }

        static void MasInfo(int numeroParametros)
        {
            Console.WriteLine("  Has introducido {0} parametros, cuando de 1 a 3 son posibles", numeroParametros);
            Console.WriteLine("  Consulta la ayuda de este programa");
        }
        #endregion
    }
}