using System;

namespace egb.Art
{
    interface ILapiz
    {
        void Pinta();
    }

    interface IPincel
    {
        void Pinta();
    }

    class Dibuja : ILapiz, IPincel
    {
        public void Pinta()
        {
            Console.WriteLine("Pinta() de Dibuja");
        }

        void IPincel.Pinta()
        {
            Console.WriteLine("Pinta() de IPincel");
        }

        void ILapiz.Pinta()
        {
            Console.WriteLine("Pinta() de ILapiz");
        }

    }

    class Inicio
    {
        static void Main()
        {
            Console.Title = "Dibujando a tope";

            Dibuja dibujeteequisdé = new Dibuja();
            ILapiz lapicito = (ILapiz)dibujeteequisdé;
            IPincel pincelillo = (IPincel)dibujeteequisdé;

            dibujeteequisdé.Pinta();
            lapicito.Pinta();
            pincelillo.Pinta();

            Console.ReadLine();
        }
    }
}
