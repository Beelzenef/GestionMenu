/*
    PROGRAMA: InfoConPath
    AUTOR: Elena Guzman Blanco
    FECHA: 23/Feb/2017
    DESCRIPCION: Este programa obtiene información de un fichero especificado
*/

using System;
using System.IO;

namespace InfoConPath
{
    class Inicio
    {
        static void ObtenerInfo()
        {
            string ruta = @"C:/basura/basura1/basura2/basura3/texto.txt ";

            Console.WriteLine("== INFORMACION SOBRE EL FICHERO Y DIRECTORIOS == ");
            Console.WriteLine("              Nombre de fichero: " + Path.GetFileName(ruta));
            Console.WriteLine("                      Extension: " + Path.GetExtension(ruta));
            Console.WriteLine("                  Ruta completa: " + Path.GetFullPath(ruta));
            Console.WriteLine("           Nombre de directorio: " + Path.GetDirectoryName(ruta));
            Console.WriteLine("Nombre de fichero sin extensión: " + Path.GetFileNameWithoutExtension(ruta));

        }

        static void Main(string[] args)
        {
            // Titulo
            Console.Title = "Obteniendo información con Clase Path";

            ObtenerInfo();

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
