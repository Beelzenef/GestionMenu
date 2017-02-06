using System;

namespace egb.UsoDelegados
{
    delegate void MiDelegado(string msg);
    delegate int OtroDelegado(int x);

    class ClaseDeMetodos
    {
        public static void Metodo1(string msg)
        {
            Console.WriteLine("Mi mensaje es: " + msg);
        }

        public void Metodo2(string msg)
        {
            Console.WriteLine("Mi mensaje es: " + msg);
        }
    }

    class Inicio
    {
        static void MetodoParaDelegado(string msg)
        {
            Console.WriteLine(msg);
        }

        static void MetodoConDevolucion(int x, int y, MiDelegado callback)
        {
            callback("La suma de es " + (x + y).ToString());
        }

        static void Main()
        {
            Console.Title = "Uso de Delegados";

            Console.WriteLine("\n==== Creando delegados ==== \n");

            // Instanciar el delegado llamado MiDelegado
            //MiDelegado llamada = MetodoParaDelegado;
            //MiDelegado llamada = new MiDelegado(MetodoParaDelegado);

            MiDelegado llamada1 = ClaseDeMetodos.Metodo1;
            llamada1("Llamada con método estático");
            MiDelegado llamada2 = new ClaseDeMetodos().Metodo2;
            llamada2("Llamada con método de instancia");
            MiDelegado llamada3 = MetodoParaDelegado;
            llamada3("Metodo para delegado");

            Console.WriteLine("\n================ MULTIDIFUSION =============\n");

            MiDelegado todosDelegado = llamada1 + llamada2;
            todosDelegado += llamada3;
            todosDelegado -= llamada1;
            todosDelegado("Mensaje común a todos los delegados");

            //llamada("hey!");
            //MetodoParaDelegado("holo!");

            //MetodoConDevolucion(10, 5, llamada);

            Console.WriteLine("\n==== Conociendo al delegado ==== \n");
            int nReferencias = todosDelegado.GetInvocationList().GetLength(0);
            Console.WriteLine("Mi delegado todosDelegado tiene {0} referencias", nReferencias);


            Console.WriteLine("\n==== Referencia a metodo anonimo ==== \n");
            OtroDelegado otroDlg = delegate (int x)
           {
               return x + 2;
           };

            Console.WriteLine(otroDlg(2));

            Console.ReadLine();
        }
    }
}
