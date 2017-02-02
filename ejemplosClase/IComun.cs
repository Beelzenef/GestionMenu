using System;

namespace egb.Nostromo
{
    interface IComun
    {
        string Nombre { get; }
        void Mostrar();
    }
    class Persona : IComun
    {
        public string Nombre
        {
            get
            {
                return "Ellen Ripley";
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Soy {0}", Nombre);
        }
    }
    class Animal : IComun
    {
        public string Nombre
        {
            get
            {
                return "Jones";
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Esto es un gatete, y hehe, no puede hablar. Se llama {0}", Nombre);
        }
    }
    class Robot : IComun
    {
        public string Nombre
        {
            get
            {
                return "Ash";
            }
        }

        public void Mostrar()
        {
            Console.WriteLine("Soy un sintético, {0}, bienvenidos a la Nostromo", Nombre);
        }
    }
    class Inicio
    {
        static void Main()
        { 
            IComun[] pasajerosNostromo = new IComun[3] {
                new Persona(), new Animal(), new Robot() };

            for (int i = 0; i < pasajerosNostromo.Length; i++)
                pasajerosNostromo[i].Mostrar();


            Console.ReadLine();
        }
    }
}
