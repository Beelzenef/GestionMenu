namespace Pizzas
{
	class Pizza
	{
		public string ANombre { get; set; }
		public string NombrePizza { get; set; }
		public bool Servida { get; set; }
		public Tipo TipoP { get; set; }
		public Tamanio TamanP { get; set; }

		public enum Tipo { Fungi, CuatroQuesos, Margarita }
		public enum Tamanio { Mediana, Familiar }

		public Pizza(string nombre, bool estado)
		{
			ANombre = nombre;
			Servida = estado;
		}

		public Pizza(string nombre, string nombrePizza, bool estado)
		{
			ANombre = nombre;
			Servida = estado;
			NombrePizza = nombrePizza;
		}

		public override string ToString()
		{
			if (NombrePizza == null)
				return "¡Marchando pizza para " + this.ANombre + ", "
					+ this.TamanP + " y " + this.TipoP + "! [" + this.Servida.ToString() +"]" ;
			return "¡Marchando pizza para " + this.ANombre + ", " + this.TamanP + " y "
				+ this.TipoP + "! (" + this.NombrePizza +") [" + this.Servida.ToString() +"]";
		}
	}
}
