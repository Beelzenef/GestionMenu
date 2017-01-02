using System;

namespace codigoISBN
{
    class codigoISBN
    {
        static bool validarISBN(string s)
        {
            int total = 0;
            int resultadoMod = 0;

            s = LimpiarCodigo(s);

            if (s.Length != 10)
                return false;

            // Sumando todos
            for (int i = 0; i < s.Length - 1; i++)
            {
                total += int.Parse(s[i].ToString()) * (i + 1);
            }

            Console.WriteLine(total);
            resultadoMod = total % 11;
            // Mod11 sobre la última posicion del codigo
            if (resultadoMod == int.Parse(s[s.Length - 1].ToString()))
                return true;
            if (resultadoMod == 10 && s[s.Length - 1] == 'X')
                return true;
            return false;
        }

        static string LimpiarCodigo(string codigo)
        {
            string codigoLimpio = string.Empty;

            for (int i = 0; i < codigo.Length; i++)
            {
                if (Char.IsNumber(codigo[i]) || codigo[i] == 'X')
                    codigoLimpio += codigo[i];
            }

            return codigoLimpio;
        }

        static string LeerSoloNumeros()
        {
            char[] numeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '-', 'X' };
            string cadenaValida = string.Empty;
            ConsoleKeyInfo tecla;

            do
            {
                tecla = Console.ReadKey(true);
                if (BusquedaSec(tecla.KeyChar, numeros) != -1)
                {
                    Console.Write(tecla.KeyChar);
                    cadenaValida += tecla.KeyChar.ToString();
                }
            } while (tecla.Key != ConsoleKey.Enter);

            return cadenaValida;
        }

        static int BusquedaSec(char datoABuscar, char[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
                if (datoABuscar == vector[i])
                    return i;
            return -1;
        }

        static void Main(string[] args)
        {
            // Variables
            string codigoAValidar = string.Empty;

            // Titulo de consola
            Console.Title = "Validando codigo ISBN";

            Console.WriteLine("¿Cual es el código ISBN que quieres validar?");
            codigoAValidar = LeerSoloNumeros ();

            if (validarISBN(LimpiarCodigo(codigoAValidar)))
                Console.WriteLine("Tu codigo, {0}, es valido", codigoAValidar);
            else
                Console.WriteLine("Tu codigo, {0}, no es valido", codigoAValidar);

            // Salida
            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
