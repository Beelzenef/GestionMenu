using System;

namespace egb.Interfaces
{
    interface ICopias
    {
        void Copiar();
    }

    class Pila : ICloneable
    {
        string msg = "Objeto PILA origen";

        public override string ToString()
        {
            return msg;
        }

        public object Clone()
        {
            Pila p = new Pila();
            p.msg = msg;
            return p;
        }
    }

    class Factura : ICloneable
    {
        string msg = "Objeto FACTURA origen";

        public override string ToString()
        {
            return msg;
        }

        public object Clone()
        {
            Factura f = new Factura();
            f.msg = msg;
            return f;
        }
    }

    class Inicio
    {
        /*// VERSION 2
        static object Copiar(Object o)
        {
            Factura f;
            Pila p;

            if (o is Factura)
            {
                f = (Factura)o;
                return f = (Factura)f.Clone();
            }
            if (o is Pila)
            {
                p = (Pila)o;
                return p = (Pila)p.Clone();
            }
            return null;
        }*/

        // VERSION 3
        static object Copiar(ICloneable i)
        {
            return i.Clone();
        }

        static void Main()
        {
            /* // VERSION 1
            Factura f1 = new Factura();
            Factura f2 = (Factura)f1.Clone();

            Console.WriteLine(f2.ToString());
            Console.WriteLine(f1.ToString());

            Pila p1 = new Pila();
            Pila p2 = (Pila)p1.Clone();
            Console.WriteLine(p2.ToString());
            Console.WriteLine(p1.ToString());
            */

           
           Factura f1 = new Factura();
           Factura f2 = (Factura)Copiar(f1);

           Console.WriteLine(f2.ToString());
           Console.WriteLine(f1.ToString());

           Pila p1 = new Pila();
            Pila p2 = (Pila)Copiar(p1);
           Console.WriteLine(p2.ToString());
           Console.WriteLine(p1.ToString());
           

            Console.ReadLine();
        }
    }

}
