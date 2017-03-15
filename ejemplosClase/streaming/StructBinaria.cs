using System;
using System.IO;
using System.Text;

namespace egb.StructBinaria
{
    struct FichaPersona
    {
        // Campos para el fichero
        string nombre;
        string apellidos;
        float sueldo;
        bool borrado;

        public string getNombre()
        {
            return nombre;
        }

        public bool getBorrado()
        {
            return borrado;
        }

        public string getApellidos()
        {
            return apellidos;
        }

        public float getSueldo()
        {
            return sueldo;
        }

        public FichaPersona(string n, string a, float s)
        {
            this.sueldo = s;
            this.apellidos = a;
            this.nombre = n;
            this.borrado = false;
        }

        public FichaPersona(string n, string a, float s, bool b)
        {
            this.sueldo = s;
            this.apellidos = a;
            this.nombre = n;
            this.borrado = b;
        }
    }

    class Inicio
    {
        static FileStream flujo;
        static BinaryWriter escritor;
        static BinaryReader lector;

        static void AnadirDatos(string rutaFichero, FichaPersona f)
        {
            flujo = new FileStream(rutaFichero, FileMode.Append);
            escritor = new BinaryWriter(flujo, Encoding.Default);

            escritor.Write(f.getNombre());
            escritor.Write(f.getApellidos());
            escritor.Write(f.getSueldo());
            escritor.Write(f.getBorrado());

            escritor.Close();
        }

        static void ListarDatos(string rutaFichero)
        {
            FichaPersona tmp;

            flujo = new FileStream(rutaFichero, FileMode.Open);
            lector = new BinaryReader(flujo);

            Console.WriteLine("               LISTADO DE DATOS");
            Console.WriteLine("==================================================");

            try
            {
                while (true)
                {
                    tmp = new FichaPersona(lector.ReadString(), lector.ReadString(), lector.ReadSingle(), lector.ReadBoolean());

                    if (!tmp.getBorrado())
                    {
                        Console.WriteLine("{0, -15} {1, -15} {2, -15}",
                            tmp.getNombre(), tmp.getApellidos(), tmp.getSueldo().ToString());
                        Console.WriteLine();
                    }
                }
            }
            catch (EndOfStreamException e)
            {
                Console.WriteLine("\n\n===== FIN DE FICHERO");
            }
            finally
            {
                lector.Close();
            }
        }

        static void Main(string[] args)
        {
            // Titulo
            Console.Title = "Una estructura binaria";

            string ruta = @"C:\pruebas\personas_binario.dat";

            FichaPersona unaPersona = new FichaPersona("Elena", "G", 100);
            FichaPersona otraPersona = new FichaPersona("Colophonius", "RdL", 100);
            AnadirDatos(ruta, unaPersona);
            AnadirDatos(ruta, otraPersona);

            ListarDatos(ruta);

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
