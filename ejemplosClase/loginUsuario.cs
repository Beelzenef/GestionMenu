using System;

namespace Identificate
{
    class Identificate
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, procedemos a identificarte como usuario en el sistema");
            LoginUsuario();
            Console.WriteLine("Pulsa ENTER para salir");
            Console.ReadLine();
        }

        static void LoginUsuario()
        {
            string user = string.Empty;
            string passUser = string.Empty;

            Console.WriteLine("¿Cual es tu usuario?");
            user = Console.ReadLine();
            Console.WriteLine("¿Contraseña?");
            passUser = PassNoEcho();

            Console.WriteLine();
            Console.WriteLine("Usuario {0}, tu contraseña es {1}", user, passw);
            Console.WriteLine("Tu contraseña es de longitud {0}, ¡poco segura!", passw.Length);
        }
        
         static void PedirPass()
        {
            string passCorrecta = "LOL";
            string passIntento = string.Empty;
            bool noValida = true;
            int nIntentos = 0;

            while (noValida && nIntentos < 3)
            {
                Console.WriteLine("\n¿Cual es la contraseña?");
                passIntento = PassNoEcho();

                if (passIntento == passCorrecta)
                    noValida = !noValida;
                nIntentos++;
            }

            if (!noValida)
                Console.WriteLine("\nHas acertado");
            else
                Console.WriteLine("\nFallaste");

        }
        
        static string PassNoEcho()
        {
            string passw = string.Empty;
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);
                if (Char.IsLetterOrDigit(tecla.KeyChar))
                {
                    passw += tecla.KeyChar;
                    Console.Write("*");
                }
            } while (tecla.Key != ConsoleKey.Enter);

            return passw;
        }
    }
}
