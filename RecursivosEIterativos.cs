using System;

namespace RecursivosEIterativos
{
    class RecursivosEIterativos
    {
        static void Main(string[] args)
        {
            // Variables
            int num = 5;

            // Titulo de consola
            Console.Title = "Metodos recursivos e iterativos";

            Console.WriteLine("Calculando el factorial de " + num);
            Console.WriteLine("Calculando...");

            Console.WriteLine("                       Resultado recursivo: " + FactRecursivo(num));
            Console.WriteLine("                       Resultado iterativo: " + FactIterativo(num));
            Console.WriteLine("Resultado recursivo con sobrecarga de byte: " + FactRecursivo((byte)num));

            // Fin de programa
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }

        static double FactRecursivo(int num)
        {
            if (num == 1 || num == 0)
                return 1;
            return num * FactRecursivo(num - 1);
        }

        static double FactRecursivo(byte n)
        {
            return (n == 1 || n == 0) ? 1 : n * FactRecursivo(n - 1);
        }

        static double FactIterativo(int num)
        {
            double resultado = 1;

            for (int i = 2; i <= num; i++)
                resultado *= i;

            return resultado;
        }
    }
}