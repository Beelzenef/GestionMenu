using System;
using System.Linq;
using System.Text;
using System.IO;

namespace PruebasFicheros
{
    class Palabros
    {
        static void Main(string[] args)
        {
            
            Menu();
            OperandoSB();
            Console.ReadLine();
        }

        static void Menu()
        {
            string ruta = @"C:\Users\Beelzenef\Desktop\texto.txt";
            string cont1 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Cras ullamcorper feugiat viverra. Donec a laoreet diam, et cursus tortor. Sed at magna eget sapien malesuada vestibulum quis in libero. Nam posuere nisl quis velit cursus accumsan. Nulla ultrices erat ut nisi pulvinar, vel consectetur ligula venenatis. Cras non diam placerat, tristique leo ut, dictum quam. Phasellus ornare tortor sagittis luctus ultrices. Maecenas porta rutrum iaculis. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Nunc at nibh nisi. Aliquam eu velit id purus lacinia gravida ac vitae mauris. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Maecenas placerat ante purus, id venenatis mauris venenatis non. In nec diam erat. Vivamus mi nibh, sodales sit amet tellus non, aliquet accumsan leo. Fusce non consequat massa.";
            string cont2 = "Jupiter Ascending mola pero no tanto";
            string[] palabrasBuscar = { "ipsum", "diam", "magna", "ligula" };
            string[] palabrasBuscar2 = { "Ascending", "pero" };

            File.WriteAllText(ruta, cont1);
            Console.WriteLine("Escribiendo en fichero");
            Console.ReadLine();
            Console.WriteLine("Leyendo fichero");

            // Mostrando palabrejas al reves
            Console.WriteLine("LoreIpsum");
            Console.WriteLine();
            Escribiendo(cont1, palabrasBuscar);
            Console.WriteLine();
            Console.WriteLine("Peliculeando");
            Console.WriteLine();
            Escribiendo(cont2, palabrasBuscar2);

        }

        static void Escribiendo(string contenido, string[] palabrasBuscar)
        {
            string[] separadores = { " ", ". ", ", " };

            string[] palabras = contenido.Split(separadores, StringSplitOptions.None);

            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabrasBuscar.Contains(palabras[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.Write(palabras[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        static void OperandoSB()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Jupiter");
            Console.WriteLine(sb.ToString());
            sb.Insert(3, "3");
            Console.WriteLine(sb.ToString());
            sb.Clear();
            Console.WriteLine(sb.ToString());
            sb.Append("Jupiter");
            sb.Replace('i', '1', 3, 1);
            sb.Replace('e', '3', 5, 1);
            Console.WriteLine(sb.ToString());
        }
    }
}
