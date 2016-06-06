using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagiaBS
{
    class Personaje
    {
        string _nombre;
        int _nivel;

        // Propiedades;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Nivel
        {
            get { return _nivel; }
            private set { _nivel = value; }
        }

    }

    class Rythmatista : Personaje
    {
        // Campos
        TiposTiza _tiza;
        CirculoInvocacion _circuloRythmatico;

        // Propiedades
        public TiposTiza Tiza
        {
            get { return _tiza; }
            private set { _tiza = value; }
        }

        public CirculoInvocacion Circulo
        {
            get { return _circuloRythmatico; }
            set { _circuloRythmatico = value; }
        }

        public bool Activacion { get; set; }

        // Metodos
        void DibujarCirculo()
        {
            Circulo = new CirculoInvocacion();
            Activacion = true;
        }

        void DestruccionDeCirculo()
        {

        }

        // Datos privados

        enum TiposTiza
        {
            Roja, Blanca, Azul
        }
    }

    class CirculoInvocacion
    {
    }
}
