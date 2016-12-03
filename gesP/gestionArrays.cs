using System;

namespace GestionPersonas
{
    struct Persona
    {
        int codigo;
        string nombre;
        string apellidos;
        int edad;
        DateTime fechaContrato;
        double sueldo;

        public int getCodigo() { return codigo; }

        public void getCodigo(int c)
        {
            if (c < 0)
                c = 0;
            if (c > 100)
                c = 100;
            codigo = c;
        }

        public string getNombre() { return nombre; }

        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getApellidos() { return apellidos; }

        public void setApellido(string a)
        {
            apellidos = a;
        }

        public int getEdad() { return edad; }

        public void setEdad(int e)
        {
            if (e < 0)
                e = 0;
            if (e > 100)
                e = 100;
            edad = e;
        }

        public double getSueldo() { return sueldo; }

        public void setSueldo(double s)
        {
            if (s < 0)
                s = 0;
            if (s > 1000)
                s = 1000;
            sueldo = s;
        }

        public DateTime getFechaC() { return fechaContrato; }

        public void setFechaC(DateTime fc)
        {
            try {
                if (fc < DateTime.Parse("01-01-1900"))
                    fc = DateTime.Parse("01-01-1900");
                if (fc > DateTime.Today)
                    fc = DateTime.Today;
                fechaContrato = fc;
            }
            catch {
                fechaContrato = DateTime.Today;
            }
        }

        public Persona(int c, string n, string a, int e, double s, string fC)
        {
            codigo = c;
            nombre = n;
            apellidos = a;
            edad = e;
            sueldo = s;
            fechaContrato = DateTime.Parse(fC);
        }

        public override string ToString()
        {
            return string.Format("Nombre {0}, Apellido(s) {1}, Edad {2}, Sueldo {3}, Fecha Contrato {4}", nombre, apellidos, edad, sueldo, fechaContrato.ToShortDateString());
        }
    }

    class GestionPersonas
    {
        static int nDatos = 0;
        static Persona[] listaPersonas = new Persona[20];

        #region Gestion de Persona

        static Persona ObtenerDatosPersona()
        {
            Persona persona;

            bool codigoValido = false;

            int codigo;
            string nombre;
            string apellidos;
            int edad;
            DateTime fechaContrato;
            int anio;
            int mes;
            int dia;
            double sueldo;

            Console.Write("¿Codigo? ");
            do {
                codigo = ObtenerNum(1, 100);
                if (BusquedaBin(codigo, listaPersonas) == -1)
                    codigoValido = true;
                else
                    Console.WriteLine("Codigo invalido, prueba con otro: ");
            } while (!codigoValido);

            Console.Write("\n¿Nombre? ");
            nombre = Console.ReadLine();
            Console.Write("¿Apellidos? ");
            apellidos = Console.ReadLine();
            Console.Write("¿Edad? ");
            edad = ObtenerNum(18, 100);
            Console.Write("Fecha de su contrato: ¿año? ");
            anio = ObtenerNum(1990, 2016);
            Console.Write("Fecha de su contrato: ¿mes? ");
            mes = ObtenerNum(1, 12);
            Console.Write("Fecha de su contrato: ¿dia? ");
            dia = ObtenerNum(1, 31);
            Console.Write("¿Sueldo? ");
            sueldo = ObtenerDouble(0, 1000);

            // Construyendo fecha
            fechaContrato = new DateTime(anio, mes, dia);

            persona = new Persona(codigo, nombre, apellidos, edad, sueldo, fechaContrato.ToString());
            return persona;
        }

        static void AnadirPersona()
        {
            Persona nuevaPersona;

            nuevaPersona = ObtenerDatosPersona();

            if (Anadir(listaPersonas, nuevaPersona)) {
                Console.WriteLine("Persona añadida con exito");
                OrdenacionBurbuja(listaPersonas);
                return;
            }
        }

        static void EditarPersona()
        {
            Persona personaEditada;
            ConsoleKeyInfo respuesta;
            int codigo = 0;
            int posicionPersona = 0;

            Console.Write("¿Codigo? ");
            codigo = ObtenerNum(1, 100);
            posicionPersona = BusquedaBin(codigo, listaPersonas);
            if (posicionPersona == -1) {
                Console.WriteLine("La persona que buscas no existe...");
                return;
            }
            Console.WriteLine(listaPersonas[posicionPersona].ToString());
            Console.WriteLine("\n¿Es esta la persona que quieres editar? Pulsa S para editar");
            if ((respuesta = Console.ReadKey()).Key != ConsoleKey.S) {
                Console.WriteLine("Tu respuesta es negativa, ¡saliendo de la edicion!");
                return;
            }
            personaEditada = ObtenerDatosPersona();
            listaPersonas[posicionPersona] = personaEditada;
            Console.WriteLine("¡Persona editada!");
        }

        static void BuscarPersona()
        {
            int codigoABuscar = 0;
            int posicionPersona = 0;

            Console.WriteLine("¿Cual es el código de la persona a buscar?");
            codigoABuscar = ObtenerNum(1, 100);
            Console.WriteLine("Buscando...");
            posicionPersona = BusquedaBin(codigoABuscar, listaPersonas);
            if (posicionPersona == -1) {
                Console.WriteLine("La persona que buscas no existe");
                return;
            }
            MostrarPersona(posicionPersona);
        }

        static void MostrarPersona(int posicion)
        {
            Persona personita = listaPersonas[posicion];
            Console.WriteLine("{0} \t {1} \t {2} \t {3,3} \t {4} \t {5,6}", personita.getCodigo(),
                                                                            personita.getNombre().PadRight(6),
                                                                            personita.getApellidos().PadRight(10),
                                                                            personita.getEdad(),
                                                                            personita.getFechaC().ToShortDateString(),
                                                                            personita.getSueldo()); }

        static void ListarPersonas()
        {
            Console.WriteLine("Cod \t Nombre \t Apellido(s) \t Edad \t Fecha de contrato \t Sueldo");
            Console.WriteLine("=====================================================================\n\n");

            for (int i = 0; i < nDatos; i++)
                MostrarPersona(i);
        }

        #endregion

        #region Gestion array

        static bool Anadir(Persona[] vector, Persona personilla)
        {
            if (vector.Length == nDatos)
                return false;
            vector[nDatos++] = personilla;
            return true;
        }

        static int BusquedaBin(int datoABuscar, Persona[] listaP)
        {
            int posIni = 0;
            int tamanio = nDatos;
            int posFinal = tamanio - 1;
            int posMedio = (posIni + posFinal) / 2; ;

            while (listaP[posMedio].getCodigo() != datoABuscar && posIni <= posFinal) {
                posMedio = (posIni + posFinal) / 2;
                if (datoABuscar > listaP[posMedio].getCodigo())
                    posIni = posMedio + 1;
                else
                    posFinal = posMedio - 1;
            }
            // ¿Ha encontrado el dato?
            if (listaP[posMedio].getCodigo() == datoABuscar)
                return posMedio;
            return -1;
        }

        static void OrdenacionBurbuja(Persona[] vector)
        {
            Persona aux;
            int tamanio = nDatos;

            for (int i = 1; i < tamanio; i++)
                for (int j = tamanio - 1; j >= i; j--)
                    if (vector[j].getCodigo() < vector[j - 1].getCodigo()) {
                        aux = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = aux;
                    }
        }

        #endregion

        #region Gestion menu

        static void DibujarMenu()
        {
            ConsoleKeyInfo tecla;

            Persona p1 = new Persona(12, "Ian", "Vextor", 23, 32, "2012-04-04");
            Persona p2 = new Persona(13, "Saul", "Preacher", 23, 32, "2012-04-04");
            Persona p3 = new Persona(1, "Solo", "Han", 23, 32, "2012-04-04");

            Anadir(listaPersonas, p1);
            Anadir(listaPersonas, p2);
            Anadir(listaPersonas, p3);
            OrdenacionBurbuja(listaPersonas);
            do {
                Console.WriteLine("           == M E N U  D E  P E R S O N A S ==\n\n");

                Console.WriteLine("\t\t1. Añadir persona");
                Console.WriteLine("\t\t2. Editar persona");
                Console.WriteLine("\t\t3. Buscar persona");
                Console.WriteLine("\t\t4. Listar personas");
                Console.WriteLine("\n\t\t\t0. Salir");

                Console.Write("\n¿Cual es tu opcion?: ");
                tecla = Console.ReadKey();
                Console.Clear();
                GestionarOpciones(tecla);
                
            } while (tecla.KeyChar != '0');
        }

        static void GestionarOpciones(ConsoleKeyInfo opcion)
        {
            switch (opcion.KeyChar) {
                case '1':
                    AnadirPersona();
                    break;
                case '2':
                    EditarPersona();
                    break;
                case '3':
                    BuscarPersona();
                    break;
                case '4':
                    ListarPersonas();
                    break;
                case '0':
                    Console.WriteLine("¡Saliendo del programa!");
                    break;
                default:
                    Console.WriteLine("La opción marcada no existe");
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
            Console.Clear();
        }

        static int ObtenerNum(int min, int max)
        {
            bool valido = false;
            int num = 0;

            Console.Write("Dame un numero... ");

            while (!valido) {
                try {
                    num = int.Parse(Console.ReadLine());
                    if (num >= min && num <= max)
                        valido = true;
                    else
                        Console.Write("Tu numero no es válido, inténtalo otra vez ");
                }
                catch {
                    Console.Write("Dato no valido, intentalo otra vez ");
                }
            }
            return num;
        }

        static double ObtenerDouble(int min, int max)
        {
            bool valido = false;
            double num = 0;

            Console.Write("Dame un numero... ");

            while (!valido) {
                try {
                    num = double.Parse(Console.ReadLine());
                    if (num >= min && num <= max)
                        valido = true;
                    else
                        Console.WriteLine("Tu numero no es válido, inténtalo otra vez ");
                }
                catch {
                    Console.Write("Dato no valido, intentalo otra vez ");
                }
            }
            return num;
        }

        #endregion

        #region Main
        static void Main(string[] args)
        {
            Console.Title = "Gestion de personas";
            try {
                DibujarMenu();
            }
            catch {
                Console.WriteLine("Algo ha salido mal, el programa se cerrará...");
            }
            // Salida
            Console.WriteLine("\n\nPulsa ENTER para salir...");
            Console.ReadLine();
        }

        #endregion
    }
}
