using System;

namespace operandoStrings
{
    class operandoStrings
    {
        static void Main(string[] args)
        {
            char[] textillo = { 'h', 'o', 'l', 'a', ' ', 'm', 'u', 'n', 'd', 'o' };
            string cadena1 = "bye";
            string cadena2 = new string(textillo);
            string cadena3 = new string('h', 10);
            string cadena4 = new string(textillo, 5, textillo.Length - 5);

            Console.Title = "Operando strings";

            filtraCaracter(cadena2, 'o');
            Console.WriteLine();
            filtraCaracter(cadena1, 'e');
            Console.WriteLine();
            Console.WriteLine(cadena4);
            Console.WriteLine(cadena3);
            filtraCaracter(cadena3, 'h');

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }
        static void filtraCaracter(string cadenita, char caracterAFiltrar)
        {
            for (int i = 0; i < cadenita.Length; i++)
            {
                if (cadenita[i] == caracterAFiltrar)
                    Console.Write('*');
                else
                    Console.Write(cadenita[i]);
            }
        }
    }
}
