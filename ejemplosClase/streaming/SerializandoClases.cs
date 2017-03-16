using System;
using System.IO;
using System.Text;

using System.Runtime.Serialization;                     // --> IFormatter
using System.Runtime.Serialization.Formatters.Binary; // --> BynaryFormatter

namespace egb.SerializandoClases
{
    [Serializable]
    class FichaPersona
    {
        // Campos para el fichero
        string nombre;
        string apellidos;
        float sueldo;
        bool borrado;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public float Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public bool Borrado
        {
            get { return borrado; }
            set { borrado = value; }
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

        public override string ToString()
        {
            return string.Format("{0,5} {1,5}, {2, 5}", Nombre, Apellidos, Sueldo.ToString());
        }
    }

    class GestionarPersona
    {
        string fichero;

        public bool AnadirPersona(FichaPersona ficha)
        {
            if (!File.Exists(fichero))
            {
                FileStream fileTMP = new FileStream(fichero, FileMode.Append);
                fileTMP.Close();
            }

            IFormatter formato = new BinaryFormatter();
            using (FileStream flujo = new FileStream(fichero, FileMode.Append, FileAccess.Write))
            {
                formato.Serialize(flujo, ficha);
            }

            return true;
        }

        public void AnadirPersonasPrueba(int nPersonas)
        {
            FichaPersona fichaTMP;
            for (int i = 0; i < nPersonas; i++)
            {
                fichaTMP = new FichaPersona(i.ToString(), i.ToString(), i);
                AnadirPersona(fichaTMP);
            }
        }
        
        public void ListarPersonas()
        {
            FichaPersona fichaTMP;

            if (!File.Exists(fichero))
            {
                Console.WriteLine("Este no es el ficheor que buscas...");
                Console.ReadLine();
                return;
            }

            using (FileStream flujo = new FileStream(fichero, FileMode.Open, FileAccess.Read))
            {
                IFormatter formato = new BinaryFormatter();

                while (true)
                {
                    try
                    {
                        fichaTMP = (FichaPersona)formato.Deserialize(flujo);
                        if (fichaTMP.Borrado)
                            continue;
                        else
                            Console.WriteLine(fichaTMP.ToString());
                    }
                    catch
                    {
                        break;
                    }
                }
            }
        }
        
        public string CrearHTML()
        {
            int nLinea = 1;
            string ficheroHTML = Path.ChangeExtension(fichero, ".html");

            if (!File.Exists(fichero))
                return string.Empty;
           
            FichaPersona fichaTMP;
            StringBuilder docHTML = new StringBuilder();

            // Cabecera
            docHTML.Append("<html>");
            docHTML.Append("<head>");
            docHTML.Append("<title> Lista de personas </title>");
            docHTML.Append("<head>");
            docHTML.Append("<body>");
            // Inicio de la tabla
            docHTML.Append("<h1> Listado de personas </h1>");
            docHTML.Append("<table border='2'>");
            docHTML.Append("<tr bgcolor='blue'> <th> Orden </th> <th> Apellidos </th> <th> Nombre </th> <th> Sueldo </th> </tr>");

            using (FileStream flujo = new FileStream(fichero, FileMode.Open, FileAccess.Read))
            {
                IFormatter formato = new BinaryFormatter();

                while (true)
                {
                    try
                    {
                        fichaTMP = (FichaPersona)formato.Deserialize(flujo);
                        if (fichaTMP.Borrado)
                            continue;
                        if (nLinea % 2 == 0)
                        {
                            docHTML.Append("<tr bgcolor='yellow'>");
                        }
                        else
                        {
                            docHTML.Append("<tr bgcolor='beige'>");
                        }
                        docHTML.Append("<td>" + nLinea++.ToString("000") + "</td>");
                        docHTML.Append("<td>" + fichaTMP.Nombre + "</td>");
                        docHTML.Append("<td>" + fichaTMP.Apellidos + "</td>");
                        docHTML.Append("<td>" + fichaTMP.Sueldo.ToString() + "</td>");
                        docHTML.Append("</tr>");
                    }
                    catch
                    {
                        break;
                    }
                }
            }

            // Fin de HTML
            docHTML.Append("</table>");
            docHTML.Append("</body>");
            docHTML.Append("</html>");

            // Escribiendo en fichero, creando fichero HTML
            FileStream flujoHTML = new FileStream(ficheroHTML, FileMode.Create, FileAccess.Write);
            StreamWriter escritor = new StreamWriter(flujoHTML, Encoding.Default);
            escritor.WriteLine(docHTML.ToString());
            escritor.Close();

            return ficheroHTML;

        }

        public GestionarPersona(string fi)
        {
            fichero = fi;
        }
    }

    class Inicio
    {
        static void Main(string[] args)
        {
            // Titulo
            Console.Title = "Serializando Clases";
            string ruta = @"C:\pruebas\nuevasPersonas.dat";

            GestionarPersona empleados = new GestionarPersona(ruta);

            empleados.AnadirPersonasPrueba(10);
            empleados.ListarPersonas();

            empleados.AnadirPersona(new FichaPersona("Elena", "G", 100));
            empleados.ListarPersonas();

            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }
    }
}
