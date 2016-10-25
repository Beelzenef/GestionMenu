/*
    PROGRAMA: ContandoVocales
    AUTOR: Elena Guzman Blanco
    FECHA: 19/Oct/2016
    DESCRIPCION: Este programa cuenta vocales de todas las letras que introduzcas
*/

using System;

namespace ContandoVocales
{
    class ContandoVocales
    {
        static void Main(string[] args)
        {
            // Variables
            int contA = 0;
            int contE = 0;
            int contI = 0;
            int contO = 0;
            int contU = 0;

            ConsoleKeyInfo teclaParaContar;
            ConsoleKeyInfo teclaDeSalida;

            // Titulo de consola
            Console.Title = "Formateando variables";

            // Primera letra y salida del bucle
            Console.WriteLine("Este programa cuenta las vocales que introduces por teclado\n");
            Console.WriteLine("¿Cual será la tecla de salida?");
            teclaDeSalida = Console.ReadKey();
            Console.WriteLine("\n\nComienza a introducir letras, y contaremos las vocales");
            Console.WriteLine("¿Cual es la primera letra?");
            teclaParaContar = Console.ReadKey();

            // Leyendo teclas en bucle
            while (teclaDeSalida.KeyChar != teclaParaContar.KeyChar)
            {
                Console.WriteLine("\n ¿Cual es tu letra? ");
                teclaParaContar = Console.ReadKey();

                switch (teclaParaContar.KeyChar)
                {
                    case 'a':
                    case 'A':
                        contA++;
                        break;
                    case 'e':
                    case 'E':
                        contE++;
                        break;
                    case 'i':
                    case 'I':
                        contI++;
                        break;
                    case 'o':
                    case 'O':
                        contO++;
                        break;
                    case 'u':
                    case 'U':
                        contU++;
                        break;
                }
            }

            // Resultados
            Console.WriteLine("\n\nResultados sin diferenciar entre mayúsculas ni minúsculas...");
            Console.WriteLine("Has introducido {0} As, {1} Es, {2} Is, {3} Os y {4} Us", contA, contE, contI, contO, contU);

            // Fin de programa
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }

    }
}