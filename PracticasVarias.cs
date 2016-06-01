using System;
using System.Collections.Generic;
using System.IO;

namespace Practicando
{
    class PracticasVarias
    {
        public static void Main(string[] args)
        {

            MostrarMenu();
            GestionP();
        }

        static void GestionP()
        {
            ConsoleKeyInfo tecla;          
            do
            {
                tecla = Console.ReadKey();
                switch (tecla.KeyChar)
                {
                    case '1':
                        ProbandoTimespan();
                        break;
                    case '2':
                        GestionColas();
                        break;
                    case '3':
                        GestionStacks();
                        break;
                    case '4':
                        LeerFichero();
                        break;
                    case '5':
                        LeerFicherosEscritorio();
                        break;
                    case '6':
                        Dadicos();
                        break;
                }
                Console.WriteLine();
                MostrarMenu();
            } while (tecla.Key != ConsoleKey.Q);
            Console.WriteLine("Saliendo del programa...");
            Console.ReadLine();
        }


        static void MostrarMenu()
        {
            Console.WriteLine("Mostrando menu");
            Console.WriteLine("1. Los días de tu vida");
            Console.WriteLine("2. Gestionando colas");
            Console.WriteLine("3. Gestionando pilas");
            Console.WriteLine("4. Leer fichero");
            Console.WriteLine("5. Leer de desktop");
            Console.WriteLine("6. Dadetes");
            Console.WriteLine("Pulsa Q para SALIR");
            Console.WriteLine();
        }
        

        static void LeerFichero()
        {
            string ruta = @"D:\USUARIO\ESCRITORIO\Persona.cs";
            string[] separadores = {": ", "; ", ", ", ". ", "/", "|", "-", " " };
            string[] lineas;
            string[] palabras;
            int numpalabras = 0;

            lineas = File.ReadAllLines(ruta);

            foreach (string item in lineas)
            {
                palabras = item.Split(separadores, StringSplitOptions.None);
                numpalabras += palabras.Length;
            }

            Console.WriteLine("Lineas {0}, palabras {1}", lineas.Length, numpalabras.ToString());
        }

        static void LeerFicherosEscritorio()
        {
            string[] ficheros;

            ficheros = Directory.GetFiles(@"D:\USUARIO\ESCRITORIO");

            foreach (string item in ficheros)
            {
                Console.WriteLine("Nombre de fichero");
                Console.WriteLine(Path.GetFileName(item));
                Console.WriteLine("Ruta de fichero");
                Console.WriteLine(item);
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        static void ProbandoTimespan()
        {
            int dia;
            int mes;
            int anio;

            Console.WriteLine("¿En que dia naciste?");
            dia = ObtenerNum();
            Console.WriteLine("¿En que mes naciste?");
            mes = ObtenerNum();
            Console.WriteLine("¿En que año naciste?");
            anio = ObtenerNum();

            DateTime fechaNac = new DateTime(anio, mes, dia);
            TimeSpan edad = DateTime.Today - fechaNac;

            Console.WriteLine(edad.ToString());

        }

        static void GestionColas()
        {
            Queue<int> cola = new Queue<int>();
            int numero;

            do
            {
               numero = ObtenerNum();
               Console.WriteLine("Encolando...");
               cola.Enqueue(numero);
               Console.WriteLine("Primer elemento en cola: {0}", cola.Peek().ToString());
            } while (numero != 0);
            Console.WriteLine();
        }

        static void GestionStacks()
        {
            int numero;
            Stack<int> pila = new Stack<int>();

            do
            {
                numero = ObtenerNum();
                pila.Push(numero);
                Console.WriteLine("Primer elemento en pila: {0}", pila.Peek().ToString());
            } while (numero != 0);
        }

        enum Dados { d10 = 10, d6 = 6, d12 = 12 }
        

        static void Dadicos()
        {
            Console.WriteLine("De diez...");
            Random dado = new Random();
            Console.WriteLine(dado.Next((int)(Dados.d10) + 1));
            Console.WriteLine("De doce...");
            Console.WriteLine(dado.Next((int)(Dados.d12) + 1));
            Console.WriteLine("De seis...");
            Console.WriteLine(dado.Next((int)(Dados.d6) + 1));
        }

        static int ObtenerNum()
        {
            bool valido = false;
            int num = 0;

            while (!valido)
            {
                try
                {
                    Console.WriteLine("Dame un numero");
                    num = int.Parse(Console.ReadLine());
                    valido = true;
                }
                catch
                {
                    Console.WriteLine("LOLNOPE");
                }
            }
            return num;
        }
    }
}
