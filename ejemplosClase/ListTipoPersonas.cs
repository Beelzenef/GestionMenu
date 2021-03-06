using System;
using System.Collections;
using System.Collections.Generic;

namespace ListaTipoPersonas
{
	enum Clases {
		Mage = 1, Warrior, Warlock, Rogue
	};

	struct FichaPersonaje {

		// Campos
		string codigo;
		string nombre;
		int nivel;
		bool borrado;
		Clases clase;

		// Constructores
		public FichaPersonaje(string cod, string n, int niv, Clases c)
		{
			if (cod.Length > 10)
				this.codigo = cod.Substring (0, 9) + "@";
			else
				this.codigo = cod;

			if (n.Length > 27)
				this.nombre = n.Substring (0, 26) + "@";
			else
				this.nombre = n;

			if (niv < 0)
				niv = 0;
			if (niv > 100)
				niv = 100;
			this.nivel = niv;

			this.clase = c;

			this.borrado = false;
		}

		// Metodos de asignacion y recuperación de datos
		public string getCodigo() {
			return this.codigo;
		}

		public void setCodigo(string cod) {
			if (cod.Length > 10)
				this.nombre = cod.Substring (0, 9) + "@";
			else
				this.nombre = cod;
		}

		public string getNombre() {
			return this.nombre;
		}

		public void setNombre(string n) {
			if (n.Length > 27)
				this.nombre = n.Substring (0, 26) + "@";
			else
				this.nombre = n;
		}

		public float getNivel() {
			return this.nivel;
		}

		public void setNivel(int niv) {

			if (niv < 0)
				niv = 0;
			if (niv > 100)
				niv = 100;
			this.nivel = niv;
		}

		public string getClase() {
			return this.clase.ToString();
		}

		public void setClase(Clases c) {
			this.clase = c;
		}

		public string getPersona() {
			return this.nombre + ", " + this.clase.ToString() + ", " + this.nivel.ToString();
		}

		public bool getBorrado()
		{
			return this.borrado;
		}

		public void setBorrado(bool b)
		{
			this.borrado = b;
		}

		public override string ToString ()
		{
			return 
				this.codigo.PadRight (10) +
				this.nombre.PadRight (20) +
				this.nivel.ToString().PadRight(8) +
				this.clase.ToString().PadRight(10);
			}
	}
		
	class ListaTipoPersonas
	{
		static FichaPersonaje LeerFicha()
		{
			string cod = string.Empty;
			string n = string.Empty;
			int lvl = 0;
			Clases c;
			FichaPersonaje? pjtillo = null;

			Console.WriteLine ("¿Codigo?");
			cod = Console.ReadLine ();
			Console.WriteLine ("¿Nombre?");
			n = Console.ReadLine ();
			Console.WriteLine ("¿Nivel?");
			lvl = ObtenerNum ();
			Console.WriteLine ("¿Clase? (R)ogue, (W)arlock, (G)uerrero, (M)age");

			switch (Console.ReadKey (true).KeyChar) {
			case 'M':
			case 'm':
				c = Clases.Mage;
				break;
			case 'G':
			case 'g':
				c = Clases.Warrior;
				break;
			case 'W':
			case 'w':
				c = Clases.Warlock;
				break;
			case 'R':
			case 'r':
				c = Clases.Rogue;
				break;
			default:
				c = Clases.Warrior;
				break;
			}

			pjtillo = new FichaPersonaje (cod, n, lvl, c);
			return (FichaPersonaje)pjtillo;
		}

		/// <summary>
		/// Lista todos los personajes existentes
		/// </summary>
		/// <param name="l">Lista de personajes que mostrar</param>
		static void ListarPersonajes(List<FichaPersonaje> l)
		{
			Console.WriteLine (string.Format("Lista de personas ({0})", l.Count.ToString()));
			Console.WriteLine ("".PadRight(70, '='));
			Console.WriteLine (	"Codigo".PadRight (10) +
								"Nombre".PadRight (20) +
								"Nivel".ToString().PadRight(8) +
								"Clase".ToString().PadRight(10));
			Console.WriteLine ("".PadRight(70, '='));
			foreach (FichaPersonaje item in l) {
				if (!item.getBorrado())
					Console.WriteLine (item.ToString ());
			}
		}

		static bool BorrarFicha(int posFicha, List<FichaPersonaje> l)
		{
			if (posFicha < 0 || posFicha > l.Count)
				return false;
			MostrarPersonaje (posFicha, l);
			Console.WriteLine ("¿Esta es la ficha que quieres borrar?");

			Console.WriteLine ("\n Pulsa 'S' para borrar, cualquier otra para CANCELAR...");
			if (Console.ReadKey (true).Key == ConsoleKey.S) {
				l [posFicha].setBorrado (true);
				Console.WriteLine ("Ficha borrada");
				return true;
			} else {
				Console.WriteLine ("Operacion cancelada...");
				return false;
			}
		}

		/// <summary>
		/// Muestra una ficha de personaje en una posicion determinada
		/// </summary>
		/// <param name="posFicha">Posicion de la ficha</param>
		/// <param name="l">Lista de personajes en la que buscar</param>
		static void MostrarPersonaje(int posFicha, List<FichaPersonaje> l)
		{
			FichaPersonaje temp;
			if (posFicha < 0 || posFicha > l.Count)
				return;
			temp = l [posFicha];
			Console.WriteLine ("".PadRight(45, '-'));
			Console.WriteLine ("DATOS PERSONALES");
			Console.WriteLine ("".PadRight(45, '-'));
			Console.WriteLine (temp.ToString());
		}

		/// <summary>
		/// Realiza búsqueda por el codigo de ficha
		/// </summary>
		/// <returns>La posicion de la ficha encontrada, o -1 si no existe</returns>
		/// <param name="aBuscar">Ficha a buscar</param>
		/// <param name="l">Lista de personajes en la que buscar</param>
		static int BuscarFicha(FichaPersonaje aBuscar, List<FichaPersonaje> l)
		{
			if (aBuscar.getCodigo().Length == 0)
				return -1;
			for (int i = 0; i < l.Count; i++)
				if (l[i].getCodigo() == aBuscar.getCodigo())
					return i;
			return -1;
		}

		/// <summary>
		/// Añade una ficha si no existe su código
		/// </summary>
		/// <param name="f">Ficha de personaje a añadir</param>
		/// <param name="l">Lista de personajes en la que buscar</param>
		static void AnadirFicha(FichaPersonaje f, List<FichaPersonaje> l)
		{
			if (BuscarFicha (f, l) == -1)
				l.Add (f);
		}
			
		static int ObtenerNum()
		{
			bool valido = false;
			int num = 0;

			Console.Write ("Dame un numero... ");

			while (!valido) {
				try {
					num = int.Parse (Console.ReadLine ());
					valido = true;
				} catch {
					Console.Write ("Dato no valido, intentalo otra vez ");
				}
			}
			return num;
		}

		static void FichasAleatorias(int nFichas, List<FichaPersonaje> l)
		{
			string[] nombres = {"Hannibal", "Eragon", "Machina", "Jane", "Katie", "Paolini", "Robert" };
			int rangoLetras = 91;
			// Variables temporales para rellenar
			string codigoTMP = string.Empty;
			string nombreTMP = string.Empty;
			int nivelTMP = 0;
			Clases claseTMP;

			Random dado = new Random ();
			FichaPersonaje fichilla;

			for (int i = 0; i < nFichas; i++) {
				codigoTMP = (dado.Next (1000000, 9999999)).ToString () + ((char)dado.Next (65, rangoLetras)).ToString ();
				nombreTMP = nombres[dado.Next(nombres.Length)];
				nivelTMP = dado.Next (101);
				claseTMP = (Clases)dado.Next (1, 5);
				fichilla = new FichaPersonaje (codigoTMP, nombreTMP, nivelTMP, claseTMP);

				AnadirFicha (fichilla, l);
			}
		}

		public static void Main (string[] args)
		{
			Console.Title = "Lista de personas";

			List<FichaPersonaje> personajes = new List<FichaPersonaje> ();

			FichaPersonaje pj = new FichaPersonaje ("123", "Elena", 13, Clases.Mage);

			AnadirFicha (pj, personajes);
			AnadirFicha (pj, personajes);
			FichasAleatorias (100, personajes);

			MostrarPersonaje (2, personajes);

			//personajes.Add(LeerFicha ());
			//personajes.Add(LeerFicha ());
			//personajes.Add(LeerFicha ());
			BorrarFicha(2, personajes);
			ListarPersonajes (personajes);

			Console.ReadLine ();
		}
	}
}
