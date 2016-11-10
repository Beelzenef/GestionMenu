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
            string passw = string.Empty;
            ConsoleKeyInfo tecla;

            Console.WriteLine("¿Cual es tu usuario?");
            user = Console.ReadLine();
            Console.WriteLine("¿Contraseña?");

            do
            {
                tecla = Console.ReadKey(true);
                Console.Write("*");
                passw += tecla.KeyChar;
            } while (tecla.Key != ConsoleKey.Enter);

            Console.WriteLine();
            Console.WriteLine("Usuario {0}, tu contraseña es {1}", user, passw);
            Console.WriteLine("Tu contraseña es de longitud {0}, ¡poco segura!", passw.Length);
        }
    }
}
