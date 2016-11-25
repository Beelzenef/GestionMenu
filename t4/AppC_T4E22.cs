/*
   PROGRAMA: MenuEjercicios
   AUTOR: Elena Guzman Blanco
   FECHA: 3/Nov/2016
   DESCRIPCION: Este programa invoca varios ejercicos reunidos en un menu
*/

using System;

namespace MenuEjercicios
{
    class MenuEjercicios
    {
        static void Main(string[] args)
        {
            // Variables
            ConsoleKeyInfo teclita;

            // Titulo de consola
            Console.Title = "Menu de ejercicios";

            do
            {
                Console.Clear();
                DibujarMenu();

                teclita = Console.ReadKey();
                GestionarOpciones(teclita);

            } while (teclita.KeyChar != '0');

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();

        }

        static void GestionarOpciones(ConsoleKeyInfo opcion)
        {
            Console.Clear();
            switch (opcion.KeyChar)
            {
                case '1': // Numero primo
                    evaluarNumPrimo();
                    break;
                case '2': // Valor absoluto
                    ValorAbsoluto();
                    break;
                case '3': // Año bisiesto
                    evaluarAnio();
                    break;
                case '4': // Ecuacion de segundo grado
                    ecSegundoGrado();
                    break;
                case '5': // Imprimir caracter
                    EscribirFilaCaracter();
                    break;
                case '0':
                    Console.WriteLine("Saliendo del programa");
                    break;
                default:
                    Console.WriteLine("Por favor, seleccione opciones entre 1 y 5");
                    break;
            }

            Console.ReadLine();

        }

        static void DibujarMenu()
        {
            Console.WriteLine("\t===========================================");
            Console.WriteLine("\t      M E N U  P R I N C I P A L");
            Console.WriteLine("\t===========================================");
            Console.WriteLine("\t      1. ¿Un número es primo?");
            Console.WriteLine("\t      2. Valor absoluto");
            Console.WriteLine("\t      3. ¿Un año es bisiesto?");
            Console.WriteLine("\t      4. Ecuación de segundo grado");
            Console.WriteLine("\t      5. Lista de caracter elegido");
            Console.WriteLine("\n\t      0. Salir");
            Console.Write("      Por favor, pulsa una opcion ");
        }

        static void ValorAbsoluto()
        {

            int num = 0;
            int numAbsoluto = 0;

            Console.WriteLine("¿Cual es el numero que deseas convertir");
            num = ObtenerNum(-1000, 1000);

            numAbsoluto = Math.Abs(num);

            Console.WriteLine("Tu numero {0} tiene como valor absoluto: {1}", num, numAbsoluto);
        }

        static void EscribirFilaCaracter()
        {
            int numVeces = 0;
            char caracterAEscribir = ' ';

            Console.WriteLine("Este programa escribe tantas veces como especifiques un caracter elegido");

            Console.WriteLine("¿Cuantas veces vas a escribir el caracter?");
            numVeces = ObtenerNum(1, 100);
            Console.WriteLine("Y ahora, ¿qué caracter quieres escribir?");
            caracterAEscribir = Console.ReadKey().KeyChar;

            for (int i = 1; i < numVeces; i++)
            {
                Console.Write(caracterAEscribir);
            }
        }

        static void evaluarAnio()
        {
            int anio = 0;
            string resultado = string.Empty;

            Console.WriteLine("Este programa evalúa si un año es bisiesto o no \n");

            anio = ObtenerNum(1900, 2100);
            resultado = esBisiesto(anio) ? "es bisiesto." : "no es bisiesto";

            Console.WriteLine("El año {0} {1}", anio, resultado);
        }

        static bool esBisiesto(int anio)
        {
            bool bisiestoONo = false;

            if (anio % 4 == 0)
            {
                if (anio % 100 == 0)
                {
                    if (anio % 400 == 0)
                    {
                        bisiestoONo = true;
                    }
                    else {
                        bisiestoONo = false;
                    }
                }
                else {
                    bisiestoONo = true;
                }
            }
            else {
                bisiestoONo = false;
            }

            return bisiestoONo;
        }

        static void evaluarNumPrimo()
        {
            int num = 0;
            string resultado = string.Empty;

            Console.WriteLine("Dame un numero para evaluar si es primo");
            num = ObtenerNum(0, 100);

            resultado = esPrimo(num) ? "es primo" : "no es primo";
            Console.WriteLine("El numero {0} {1}", num, resultado);
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

        static void ecSegundoGrado()
        {
            int numA = 0;
            int numB = 0;
            int numC = 0;
            double resultado = 0;

            Console.WriteLine("Resolviendo ecuaciones de segundo grado");
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

            Console.WriteLine("El resultado es {0}", resultado);
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