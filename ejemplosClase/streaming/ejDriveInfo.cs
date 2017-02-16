using System;
using System.IO;

namespace egb.usoDriveInfo
{
    class Inicio
    {
        static void Main()
        {
            Console.Title = "Unidades con DriveInfo";

            DriveInfo[] unidades = DriveInfo.GetDrives();

            Console.WriteLine("Unidades en disco");

            foreach (DriveInfo item in unidades)
            {
                Console.WriteLine("".PadRight(50, '='));
                if (item.IsReady)
                {
                    Console.WriteLine("NOMBRE =" + item.Name);
                    Console.WriteLine("ESPACIO LIBRE TOTAL =" + item.TotalFreeSpace);
                    Console.WriteLine("ESPACIO LIBRE DISPONIBLE =" + item.AvailableFreeSpace);
                    Console.WriteLine("TAMAÑO TOTAL =" + item.TotalSize);
                    Console.WriteLine("FORMATO DE UNIDAD =" + item.DriveFormat);
                    Console.WriteLine("TIPO DE UNIDAD =" + item.DriveType);
                    Console.WriteLine("ETIQUETA DE VOLUMEN =" + item.VolumeLabel);
                }
                else
                    Console.WriteLine("La unidad en cuestión no está lista...");
            }
            
            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();    
        }
    }
}
