using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ---
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Persona p = new Persona(23, "Elena");
            Serializador(p);
            DesSerializador();
            Console.ReadLine();
        }

        static bool Serializador(Persona per)
        {
            string rutaSalida = @"C:\basura\salida.txt";

            FileStream fichero = new FileStream(rutaSalida, FileMode.Create, FileAccess.Write);
            IFormatter formateador = new BinaryFormatter();

            try
            {
                formateador.Serialize(fichero, per);
                return true;
            }
            catch
            {
                Console.WriteLine("Error serializando");
            }
            finally
            {
                fichero.Close();
            }
            return false;
        }

        static bool DesSerializador()
        {
            string rutaSalida = @"C:\basura\salida.txt";
            string rutaEntrada = @"C:\basura\entrada.txt";

            FileStream fichero = new FileStream(rutaSalida, FileMode.Open, FileAccess.Read);
            IFormatter formateador = new BinaryFormatter();

            try
            {
                Persona pTMP = (Persona)formateador.Deserialize(fichero);
                File.WriteAllText(rutaEntrada, pTMP.Edad + pTMP.Nombre);
                return true;
            }
            catch
            {
                Console.WriteLine("Error deserializando");
            }
            finally
            {
                fichero.Close();
            }
            return false;
        }
    }
}
