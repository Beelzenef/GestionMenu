using System;
using System.Threading;

namespace TextoQueFlota
{
    class TextoQueFlota
    {
        static void Main(string[] args)
        {
            Console.Title = "-> y <-, cambiar velocidad, SPACE cambiar texto";
            TextoFlotante();

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();

        }

        static void TextoFlotante()
        {
            bool flotando = true;
            int velocidad = 100;
            ConsoleKeyInfo tecla;
            string texto = "Texto flotando";
            int pos = 0;
            bool derecha = true;

            while (flotando)
            {
                if (Console.KeyAvailable)
                {
                    tecla = Console.ReadKey();
                    if (tecla.Key == ConsoleKey.LeftArrow)
                    {
                        velocidad += 3;
                        if (velocidad > 300)
                            velocidad = 300;
                    }
                    if (tecla.Key == ConsoleKey.RightArrow)
                    {
                        velocidad -= 3;
                        if (velocidad < 50)
                            velocidad = 50;
                    }
                    if (tecla.Key == ConsoleKey.Spacebar)
                        texto = CambiarTexto();
                    if (tecla.Key == ConsoleKey.Escape)
                        flotando = false;
                }
                Thread.Sleep(velocidad);
                if (pos + texto.Length == 79)
                    derecha = false;
                if (pos == 0)
                    derecha = true;

                if (derecha)
                    pos++;
                else
                    pos--;
                Console.Clear();
                Console.CursorLeft = pos;
                Console.Write(texto);
            }
        }

        static string CambiarTexto()
        {
            Console.Clear();
            Console.WriteLine("¿Cual es tu nueva frase?");
            string resultado = string.Empty;
            resultado = Console.ReadLine();
            return resultado;
        }
    }
}