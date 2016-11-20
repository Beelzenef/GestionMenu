using System;

namespace DecABin
{
    class DecABin
    {
        static void Main(string[] args)
        {
            string binario = string.Empty;
            int numDec = 0;

            // Titulo
            Console.Title = "Decimal a binario";
            Console.WriteLine("Dame un numerico para convertir");
            numDec = ObtenerNum(1, 100);

            Console.WriteLine("Calculando...");
            Console.WriteLine("Decimal a binario iterativo: " + DecABinIterativo(numDec));

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();

        }

        static string DecABinIterativo(int nDecimal)
        {
            string resultado = string.Empty;
            int resto = 0;

            while (nDecimal >= 1)
            {
                resto = nDecimal % 2;
                nDecimal = nDecimal / 2;
                resultado = resto.ToString() + resultado;
            }

            return resultado;
        }

        static int ObtenerNum(int min, int max)
        {
            bool valido = false;
            int num = 0;

            Console.Write("Dame un numero... ");

            while (!valido)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    if (num >= min && num <= max)
                        valido = true;
                    else
                        Console.WriteLine("Tu numero no es válido, inténtalo otra vez ");
                }
                catch
                {
                    Console.Write("Dato no valido, intentalo otra vez ");
                }
            }
            Console.WriteLine("Tu numero es válido, ¡procede!");
            return num;
        }
    }
}