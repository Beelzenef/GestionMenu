namespace Pizzas
{
	partial class form_Pizzas
	{
		/// <summary>
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbC_Pizzeria = new System.Windows.Forms.TabControl();
			this.tbP_Usuario = new System.Windows.Forms.TabPage();
			this.grB_Guardada = new System.Windows.Forms.GroupBox();
			this.txtB_Guardado = new System.Windows.Forms.TextBox();
			this.grB_Nombre = new System.Windows.Forms.GroupBox();
			this.txtB_Nombre = new System.Windows.Forms.TextBox();
			this.tbP_Pedido = new System.Windows.Forms.TabPage();
			this.btn_PedirPizza = new System.Windows.Forms.Button();
			this.grB_Tamanos = new System.Windows.Forms.GroupBox();
			this.cmB_Tams = new System.Windows.Forms.ComboBox();
			this.grB_Tipos = new System.Windows.Forms.GroupBox();
			this.cmB_Tips = new System.Windows.Forms.ComboBox();
			this.tbP_Mostrador = new System.Windows.Forms.TabPage();
			this.grB_Servidas = new System.Windows.Forms.GroupBox();
			this.lbl_Servidas = new System.Windows.Forms.Label();
			this.grB_Pedidas = new System.Windows.Forms.GroupBox();
			this.lbl_Pedidas = new System.Windows.Forms.Label();
			this.tbC_Pizzeria.SuspendLayout();
			this.tbP_Usuario.SuspendLayout();
			this.grB_Guardada.SuspendLayout();
			this.grB_Nombre.SuspendLayout();
			this.tbP_Pedido.SuspendLayout();
			this.grB_Tamanos.SuspendLayout();
			this.grB_Tipos.SuspendLayout();
			this.tbP_Mostrador.SuspendLayout();
			this.grB_Servidas.SuspendLayout();
			this.grB_Pedidas.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbC_Pizzeria
			// 
			this.tbC_Pizzeria.Controls.Add(this.tbP_Usuario);
			this.tbC_Pizzeria.Controls.Add(this.tbP_Pedido);
			this.tbC_Pizzeria.Controls.Add(this.tbP_Mostrador);
			this.tbC_Pizzeria.Location = new System.Drawing.Point(7, 12);
			this.tbC_Pizzeria.Name = "tbC_Pizzeria";
			this.tbC_Pizzeria.SelectedIndex = 0;
			this.tbC_Pizzeria.Size = new System.Drawing.Size(368, 196);
			this.tbC_Pizzeria.TabIndex = 1;
			// 
			// tbP_Usuario
			// 
			this.tbP_Usuario.Controls.Add(this.grB_Guardada);
			this.tbP_Usuario.Controls.Add(this.grB_Nombre);
			this.tbP_Usuario.Location = new System.Drawing.Point(4, 22);
			this.tbP_Usuario.Name = "tbP_Usuario";
			this.tbP_Usuario.Padding = new System.Windows.Forms.Padding(3);
			this.tbP_Usuario.Size = new System.Drawing.Size(360, 170);
			this.tbP_Usuario.TabIndex = 0;
			this.tbP_Usuario.Text = "¡Tus datos para venderlos a Google!";
			this.tbP_Usuario.UseVisualStyleBackColor = true;
			// 
			// grB_Guardada
			// 
			this.grB_Guardada.Controls.Add(this.txtB_Guardado);
			this.grB_Guardada.Location = new System.Drawing.Point(33, 84);
			this.grB_Guardada.Name = "grB_Guardada";
			this.grB_Guardada.Size = new System.Drawing.Size(293, 52);
			this.grB_Guardada.TabIndex = 3;
			this.grB_Guardada.TabStop = false;
			this.grB_Guardada.Text = "¿Quieres guardar esta pizza con un nombre memorable?";
			// 
			// txtB_Guardado
			// 
			this.txtB_Guardado.Location = new System.Drawing.Point(19, 19);
			this.txtB_Guardado.Name = "txtB_Guardado";
			this.txtB_Guardado.Size = new System.Drawing.Size(259, 20);
			this.txtB_Guardado.TabIndex = 0;
			// 
			// grB_Nombre
			// 
			this.grB_Nombre.Controls.Add(this.txtB_Nombre);
			this.grB_Nombre.Location = new System.Drawing.Point(33, 26);
			this.grB_Nombre.Name = "grB_Nombre";
			this.grB_Nombre.Size = new System.Drawing.Size(246, 52);
			this.grB_Nombre.TabIndex = 3;
			this.grB_Nombre.TabStop = false;
			this.grB_Nombre.Text = "¡Tu nombre!";
			// 
			// txtB_Nombre
			// 
			this.txtB_Nombre.Location = new System.Drawing.Point(19, 19);
			this.txtB_Nombre.Name = "txtB_Nombre";
			this.txtB_Nombre.Size = new System.Drawing.Size(210, 20);
			this.txtB_Nombre.TabIndex = 0;
			// 
			// tbP_Pedido
			// 
			this.tbP_Pedido.Controls.Add(this.btn_PedirPizza);
			this.tbP_Pedido.Controls.Add(this.grB_Tamanos);
			this.tbP_Pedido.Controls.Add(this.grB_Tipos);
			this.tbP_Pedido.Location = new System.Drawing.Point(4, 22);
			this.tbP_Pedido.Name = "tbP_Pedido";
			this.tbP_Pedido.Padding = new System.Windows.Forms.Padding(3);
			this.tbP_Pedido.Size = new System.Drawing.Size(360, 170);
			this.tbP_Pedido.TabIndex = 1;
			this.tbP_Pedido.Text = "¡Tu pizza!";
			this.tbP_Pedido.UseVisualStyleBackColor = true;
			// 
			// btn_PedirPizza
			// 
			this.btn_PedirPizza.Enabled = false;
			this.btn_PedirPizza.Location = new System.Drawing.Point(209, 72);
			this.btn_PedirPizza.Name = "btn_PedirPizza";
			this.btn_PedirPizza.Size = new System.Drawing.Size(120, 32);
			this.btn_PedirPizza.TabIndex = 4;
			this.btn_PedirPizza.Text = "¡Pide tu pizza!";
			this.btn_PedirPizza.UseVisualStyleBackColor = true;
			this.btn_PedirPizza.Click += new System.EventHandler(this.btn_PedirPizza_Click);
			// 
			// grB_Tamanos
			// 
			this.grB_Tamanos.Controls.Add(this.cmB_Tams);
			this.grB_Tamanos.Location = new System.Drawing.Point(19, 87);
			this.grB_Tamanos.Name = "grB_Tamanos";
			this.grB_Tamanos.Size = new System.Drawing.Size(184, 52);
			this.grB_Tamanos.TabIndex = 3;
			this.grB_Tamanos.TabStop = false;
			this.grB_Tamanos.Text = "¿Que tamaño?";
			// 
			// cmB_Tams
			// 
			this.cmB_Tams.FormattingEnabled = true;
			this.cmB_Tams.Items.AddRange(new object[] {
            "Mediana",
            "Familiar"});
			this.cmB_Tams.Location = new System.Drawing.Point(17, 19);
			this.cmB_Tams.Name = "cmB_Tams";
			this.cmB_Tams.Size = new System.Drawing.Size(141, 21);
			this.cmB_Tams.TabIndex = 0;
			this.cmB_Tams.SelectedIndexChanged += new System.EventHandler(this.SeleccionarCombo_SelectedIndexChanged);
			// 
			// grB_Tipos
			// 
			this.grB_Tipos.Controls.Add(this.cmB_Tips);
			this.grB_Tipos.Location = new System.Drawing.Point(19, 29);
			this.grB_Tipos.Name = "grB_Tipos";
			this.grB_Tipos.Size = new System.Drawing.Size(184, 52);
			this.grB_Tipos.TabIndex = 2;
			this.grB_Tipos.TabStop = false;
			this.grB_Tipos.Text = "¿De que tipo?";
			// 
			// cmB_Tips
			// 
			this.cmB_Tips.FormattingEnabled = true;
			this.cmB_Tips.Items.AddRange(new object[] {
            "Funghi",
            "Margarita",
            "4 Quesos"});
			this.cmB_Tips.Location = new System.Drawing.Point(17, 19);
			this.cmB_Tips.Name = "cmB_Tips";
			this.cmB_Tips.Size = new System.Drawing.Size(141, 21);
			this.cmB_Tips.TabIndex = 0;
			this.cmB_Tips.SelectedIndexChanged += new System.EventHandler(this.SeleccionarCombo_SelectedIndexChanged);
			// 
			// tbP_Mostrador
			// 
			this.tbP_Mostrador.Controls.Add(this.grB_Servidas);
			this.tbP_Mostrador.Controls.Add(this.grB_Pedidas);
			this.tbP_Mostrador.Location = new System.Drawing.Point(4, 22);
			this.tbP_Mostrador.Name = "tbP_Mostrador";
			this.tbP_Mostrador.Padding = new System.Windows.Forms.Padding(3);
			this.tbP_Mostrador.Size = new System.Drawing.Size(360, 170);
			this.tbP_Mostrador.TabIndex = 2;
			this.tbP_Mostrador.Text = "¡Marchando!";
			this.tbP_Mostrador.UseVisualStyleBackColor = true;
			// 
			// grB_Servidas
			// 
			this.grB_Servidas.Controls.Add(this.lbl_Servidas);
			this.grB_Servidas.Location = new System.Drawing.Point(56, 79);
			this.grB_Servidas.Name = "grB_Servidas";
			this.grB_Servidas.Size = new System.Drawing.Size(246, 52);
			this.grB_Servidas.TabIndex = 3;
			this.grB_Servidas.TabStop = false;
			this.grB_Servidas.Text = "Servidas";
			// 
			// lbl_Servidas
			// 
			this.lbl_Servidas.AutoSize = true;
			this.lbl_Servidas.Location = new System.Drawing.Point(106, 20);
			this.lbl_Servidas.Name = "lbl_Servidas";
			this.lbl_Servidas.Size = new System.Drawing.Size(13, 13);
			this.lbl_Servidas.TabIndex = 1;
			this.lbl_Servidas.Text = "0";
			// 
			// grB_Pedidas
			// 
			this.grB_Pedidas.Controls.Add(this.lbl_Pedidas);
			this.grB_Pedidas.Location = new System.Drawing.Point(56, 21);
			this.grB_Pedidas.Name = "grB_Pedidas";
			this.grB_Pedidas.Size = new System.Drawing.Size(246, 52);
			this.grB_Pedidas.TabIndex = 2;
			this.grB_Pedidas.TabStop = false;
			this.grB_Pedidas.Text = "Pedidas";
			// 
			// lbl_Pedidas
			// 
			this.lbl_Pedidas.AutoSize = true;
			this.lbl_Pedidas.Location = new System.Drawing.Point(106, 16);
			this.lbl_Pedidas.Name = "lbl_Pedidas";
			this.lbl_Pedidas.Size = new System.Drawing.Size(13, 13);
			this.lbl_Pedidas.TabIndex = 0;
			this.lbl_Pedidas.Text = "0";
			// 
			// form_Pizzas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(376, 212);
			this.Controls.Add(this.tbC_Pizzeria);
			this.MaximizeBox = false;
			this.Name = "form_Pizzas";
			this.Text = "PizzaPlanet";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.tbC_Pizzeria.ResumeLayout(false);
			this.tbP_Usuario.ResumeLayout(false);
			this.grB_Guardada.ResumeLayout(false);
			this.grB_Guardada.PerformLayout();
			this.grB_Nombre.ResumeLayout(false);
			this.grB_Nombre.PerformLayout();
			this.tbP_Pedido.ResumeLayout(false);
			this.grB_Tamanos.ResumeLayout(false);
			this.grB_Tipos.ResumeLayout(false);
			this.tbP_Mostrador.ResumeLayout(false);
			this.grB_Servidas.ResumeLayout(false);
			this.grB_Servidas.PerformLayout();
			this.grB_Pedidas.ResumeLayout(false);
			this.grB_Pedidas.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tbC_Pizzeria;
		private System.Windows.Forms.TabPage tbP_Usuario;
		private System.Windows.Forms.TabPage tbP_Pedido;
		private System.Windows.Forms.TabPage tbP_Mostrador;
		private System.Windows.Forms.GroupBox grB_Pedidas;
		private System.Windows.Forms.GroupBox grB_Tamanos;
		private System.Windows.Forms.ComboBox cmB_Tams;
		private System.Windows.Forms.GroupBox grB_Tipos;
		private System.Windows.Forms.ComboBox cmB_Tips;
		private System.Windows.Forms.GroupBox grB_Servidas;
		private System.Windows.Forms.GroupBox grB_Guardada;
		private System.Windows.Forms.TextBox txtB_Guardado;
		private System.Windows.Forms.GroupBox grB_Nombre;
		private System.Windows.Forms.TextBox txtB_Nombre;
		private System.Windows.Forms.Button btn_PedirPizza;
		private System.Windows.Forms.Label lbl_Servidas;
		private System.Windows.Forms.Label lbl_Pedidas;
	}
}

