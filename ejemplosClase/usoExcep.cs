using System;
using System.Collections.Generic;

namespace egb.UsoExcepciones
{
    class Inicio
    {
        static int cero = 0;
        static List<int> listilla;// = new List<int>();

        static void Main()
        {
            Console.Title = "Uso de Excepciones";

            Exception unaException = new Exception("hello, its me... AN ERROR!");
            Console.WriteLine(unaException.Message);

            try
            {
                listilla.Add(5);
                if (cero == 0)
                    throw new DivideByZeroException("Repasa las matemáticas...");
                int j = 22 / cero;
            }
            catch (Exception e)
            {
                Console.WriteLine("Msg:     " + e.Message);
                Console.WriteLine("App:     " + e.Source);
                Console.WriteLine("Metodo:  " + e.TargetSite);
                Console.WriteLine("Tipo:    " + e.GetType());
            }

            Console.ReadLine();
           
        }
    }
}
