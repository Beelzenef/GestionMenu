using System;
using System.Collections;
using System.Collections.Generic;

namespace PruebasFicheros
{
    public class P1
    {
        public static void CreaMergeListas()
        {
            ArrayList lista1 = new ArrayList();
            ArrayList lista2 = new ArrayList();

            lista1.Add(1);
            lista1.Add("Hola");

            lista2.Add("Elemento en lista 2");
            lista2.AddRange(lista1);

            List<string> listilla = new List<string>();
            listilla.Add("Lista");

            lista2.AddRange(listilla);

            Mostrar(lista2);

        }

        public static void Mostrar(ArrayList ls)
        {
            foreach (object item in ls)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
