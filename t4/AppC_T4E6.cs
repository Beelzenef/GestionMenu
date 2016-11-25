/*
   PROGRAMA: ecSegundoGrado
   AUTOR: Elena Guzman Blanco
   FECHA: 3/Nov/2016
   DESCRIPCION: Este programa resuelve ecuaciones de segundo grado
*/

using System;

namespace ecSegundoGrado
{
    class ecSegundoGrado
    {
        static void Main(string[] args)
        {
            // Titulo de consola
            Console.Title = "Ecuaciones de segundo grado";

            ecuacionSegundoGrado();

            Console.WriteLine("Saliendo del programa");
            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();

        }

        static void ecuacionSegundoGrado()
        {
            int numA = 0;
            int numB = 0;
            int numC = 0;
            double resultado = 0;

            Console.WriteLine("Resolviendo ecuaciones de segundo grado\n\n");
            Console.WriteLine("¿Cuál es el primer término?");
            numA = ObtenerNum(0, 100);
            Console.WriteLine("¿Cual es el segundo término?");
            numB = ObtenerNum(0, 100);
            Console.WriteLine("¿Cual es el tercer término?");
            numC = ObtenerNum(0, 100);

            Console.WriteLine("Calculando...");

            if (numA > 0 && numB > 0 && numC > 0)
                resultado = Math.Abs((-numB + Math.Sqrt(Math.Pow(numB, 2) - 4 * numA * numC)) / 2 * numA);
            else {
                if (numB == 0 && numC == 0)
                    resultado = 0;
                else {
                    if (numA == 0)
                    {
                        Console.WriteLine("La ecuacion no tiene raices reales");
                        return;
                    }
                    if (numC == 0)
                        resultado = -numB / numA;
                    if (numB == 0)
                        resultado = Math.Abs(Math.Sqrt((double)-numC / numA));
                }
            }
            resultado = Math.Abs(resultado);
            Console.WriteLine("El resultado es {0}", resultado);
        }

        static bool esPrimo(int num)
        {
            int contador = 0;

            for (int i = 1; i < num + 1; i++)
            {
                if (num % i == 0)
                    contador++;

                if (contador > 2)
                    return false;
            }
            return true;
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