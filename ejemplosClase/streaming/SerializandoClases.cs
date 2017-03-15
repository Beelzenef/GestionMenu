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

        public GestionarPersona(string fi)
        {
            fichero = fi;
        }
    }
}
