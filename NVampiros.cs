using System;
using System.Collections.Generic;

namespace NVampiros
{
    class NVampiros
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int colmilloP = 0;
            int colmilloS = 0;
            int nVampiro = 0;

            Console.WriteLine("El primero colmillo será...");
            colmilloP = ObtenerNum();
            Console.WriteLine("El segundo colmillo será...");
            colmilloS = ObtenerNum();
            nVampiro = CalcularVampiro(colmilloP, colmilloS);
            Console.ReadLine();
        }

        static bool EsVampiro(int C1, int C2, int nV)
        {
            return false;
        }

        static int CalcularVampiro(int C1, int C2)
        {
            int resultado = 0;
            resultado = C1 * C2;
            return resultado;
        }

        static int ObtenerNum()
        {
            int numero = 0;
            bool valido = false;

            while (!valido)
            {
                try
                {
                    Console.WriteLine("Dame un numero...");
                    numero = int.Parse(Console.ReadLine());
                    if (numero.ToString().Length == 2)
                    {
                        valido = true;
                    }
                }
                catch
                {
                    Console.WriteLine("No valido");
                }
            }

            return numero;
        }
    }
}
