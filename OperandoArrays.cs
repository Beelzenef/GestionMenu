using System;

namespace OperandoArrays
{
    class OperandoArrays
    {
        static void Main(string[] args)
        {
            // Variables
            int[] listilla = { };
            string[] listillaPalabras = {"C#", "Python", "SASS", "Javascript" };

            // Titulo de consola
            Console.Title = "Operando arrays";

            Console.WriteLine("Utilizando listas, arrays");
            listilla = LlenarDatos();
            ListarDatos(listilla);
            Console.WriteLine();
            ListarDatos(listillaPalabras);

            // Fin de programa
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }

        static void ListarDatos(int[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
                Console.Write("{0}\t", datos[i]);
        }

        static void ListarDatos(string[] datos)
        {
            for (int i = 0; i < datos.Length; i++)
                Console.Write("{0}\t", datos[i]);
        }

        static int[] LlenarDatos()
        {
            int[] datos = new int[5];

            for (int i = 0; i < datos.Length; i++)
                datos[i] = i + 1;

            return datos;
        }
    }
}
