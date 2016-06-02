using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Pizzas
{
	public partial class form_Pizzas : Form
	{
		public form_Pizzas()
		{
			InitializeComponent();
		}

		int pedidas = 0;
		int servidas = 0;
		int contPizzasServidas = 0;
		List<Pizza> listaPizzas = new List<Pizza>();

		private void btn_PedirPizza_Click(object sender, EventArgs e)
		{
			PizzaPedida();
			ActualizarPizzas();
			MostradorPizzas();
		}

		private void MostradorPizzas()
		{
			lbl_Pedidas.Text = pedidas.ToString();
			lbl_Servidas.Text = servidas.ToString();
		}

		private void PizzaPedida()
		{
			InstanciaPizza(cmB_Tips.SelectedItem.ToString(), cmB_Tams.SelectedItem.ToString());
			pedidas++;
		}

		private void InstanciaPizza(string tipo, string tamanio)
		{
			Pizza pTMP;
			if (txtB_Guardado.Text.Length > 0)
				pTMP = new Pizza(txtB_Nombre.Text, txtB_Guardado.Text, false);
			else
				pTMP = new Pizza(txtB_Nombre.Text, false);
	
			// Tipos
			if (tipo == "4 Quesos")
				pTMP.TipoP = Pizza.Tipo.CuatroQuesos;
			else if (tipo == "Margarita")
				pTMP.TipoP = Pizza.Tipo.Margarita;
			else if (tipo == "Funghi")
				pTMP.TipoP = Pizza.Tipo.Fungi;
			
			// Tamaños
			if (tamanio == "Mediana")
				pTMP.TamanP = Pizza.Tamanio.Mediana;
			else if (tamanio == "Familiar")
				pTMP.TamanP = Pizza.Tamanio.Familiar;

			this.Text = pTMP.ToString();
			listaPizzas.Add(pTMP);
		}

		private void ActualizarPizzas()
		{
			if (pedidas % 2 == 0)
			{
				servidas++;
				listaPizzas[contPizzasServidas].Servida = true;
				contPizzasServidas++;
			}
		}

		private void SeleccionarCombo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmB_Tips.SelectedIndex >= 0 && cmB_Tams.SelectedIndex >= 0)
				btn_PedirPizza.Enabled = true;
		}


		#region Guardar

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				if (listaPizzas.Count > 0)
				{
					Guardado();
					MessageBox.Show("El registro de pizzas se ha guardado");
				}
			}
			catch
			{
				MessageBox.Show("No se ha podido guardar");
			}
		}

		private void Guardado()
		{
			string[] lineas = new string[listaPizzas.Count];

			for (int i = 0; i < lineas.Length; i++)
			{
				lineas[i] = listaPizzas[i].ToString();
			}

			File.WriteAllLines(Directory.GetCurrentDirectory() + @"\pizzas.txt", lineas);
		} 
		#endregion
	}
}
