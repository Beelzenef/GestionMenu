using System;

namespace saludete
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para cambio de bits a 1
            // Numero a manipular: 0000 000A || 0000 .... 1010
            int datoOR = 10;
            // Dependiendo de la operacion a realizar, necesitaremos una mascara, un número que tiene
            // 1s en determinadas posiciones: 0000 0007 || 0000 .... 0111
            int mascaraOR = 7;

            // Para cambio de bits a 0
            int datoAND = 9;
            int mascaraAND = 0;

            // Formato para consola
            string separador = "\n===========================\n";

            
            Console.WriteLine("{0} & {1} resulta en {2}, y en hexa {2:X}", datoOR, mascaraOR, datoOR & mascaraOR);
            Console.WriteLine("{0} | {1} resulta en {2}, y en hexa {2:X}", datoOR, mascaraOR, datoOR | mascaraOR);
            Console.WriteLine("{0} ^ {1} resulta en {2}, y en hexa {2:X}", datoOR, mascaraOR, datoOR ^ mascaraOR);
            Console.WriteLine(separador);

            Console.WriteLine("\nOperando con OR...");
            Console.WriteLine("Poner a 1 el bit 2 de {0} (o en hex {0:X})", datoAND);
            mascaraAND = 8; // 0100, 2^2 por ser posicion 2
            Console.WriteLine("Bit cambiado que da {0} y en hexa {0:X}", datoAND | mascaraAND);

            Console.WriteLine("\nOperando con AND...");
            Console.WriteLine("Poner a 0 el bit 2 de {0} (o en hex {0:X})", datoAND);
            mascaraAND = 14; // 0100
            Console.WriteLine("Bit cambiado que da {0} y en hexa {0:X}", datoAND & mascaraAND);

            Console.WriteLine(separador);
            Console.WriteLine("Pulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
