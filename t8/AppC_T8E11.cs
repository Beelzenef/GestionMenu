/*
    PROGRAMA: GuardarTextoFichero
    AUTOR: Elena Guzman Blanco
    FECHA: 1/Marzo/2017
    DESCRIPCION: Este programa toma un texto por teclado, lo escribe por pantalla y lo guarda también en un fichero
*/

using System;
using System.IO;

namespace egb.GuardarTextoFichero
{
    class Inicio
    {
        public static void Main()
        {
            string texto = string.Empty;
            string ruta = string.Empty;

            Console.Title = "Texto a guardar en fichero";

            Console.WriteLine("Escribe cualquier texto, y se mostrará por pantalla, además de ser guardado en un fichero ¡Empieza a escribir! ");
            texto = Console.ReadLine();
            Console.WriteLine("\n¿Dónde se guardará este texto? Escribe una ruta válida: ");
            ruta = @Console.ReadLine();

            Console.WriteLine("\nTu texto: \n\'" + @texto + "\'");

            if (Directory.Exists(ruta))
                File.WriteAllText(ruta, @texto);
            else
                Console.WriteLine("La ruta que has escrito no existe, y el fichero no se ha guardado...");
            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}