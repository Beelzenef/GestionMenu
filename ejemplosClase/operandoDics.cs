using System;
using System.Collections.Generic;

namespace operandoDics
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

	class operandoDics
	{
		static Dictionary<string, FichaPersonaje> dic1 = new Dictionary<string, FichaPersonaje> ();

		static bool BuscarFicha(FichaPersonaje aBuscar)
		{
			if (dic1.ContainsKey (aBuscar.getCodigo ()))
				return true;
			return false;
		}
			
		static void AnadirFicha(FichaPersonaje f)
		{
			if (!BuscarFicha (f))
				dic1.Add (f.getCodigo(), f);
		}

		static void FichasAleatorias(int nFichas)
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

				AnadirFicha (fichilla);
			}
		}

		static void MostrarDic()
		{
			Console.WriteLine ("".PadRight(60, '-'));
			Console.WriteLine ("\t\tD A T O S  D E  P E R S O N A J E S");
			Console.WriteLine ("".PadRight(60, '-'));
			foreach (KeyValuePair<string, FichaPersonaje> item in dic1)
				Console.WriteLine (item.ToString());
		}

		public static void Main (string[] args)
		{
			Console.Title = "Operando con diccionarios";

			FichasAleatorias (100);
			Console.WriteLine (dic1.Count);
			MostrarDic ();

			Console.ReadLine ();
		}
	}
}
