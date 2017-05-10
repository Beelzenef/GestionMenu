using System.Windows;

namespace AppWPF_ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ListaPersonas listitaPersonas;

        public MainWindow()
        {
            InitializeComponent();
            listitaPersonas = new ListaPersonas();
            lsV_Jugadores.ItemsSource = listitaPersonas;
        }

        private void btn_AnadirDatos_Click(object sender, RoutedEventArgs e)
        {
            if (txtB_Nombre.Text.Length == 0 || txtB_NombrePJ.Text.Length == 0)
                return;

            try
            {
                listitaPersonas.Add(new Persona(txtB_Nombre.Text, txtB_NombrePJ.Text, int.Parse(txtB_NivelPJ.Text)));
                LimpiarTxtBoxes();
            }
            catch
            {
                MessageBox.Show("Persona imposible de añadir");
            }
        }

        private void btn_EliminarDatos_Click(object sender, RoutedEventArgs e)
        {
            if (lsV_Jugadores.SelectedIndex == -1)
                return;

            listitaPersonas.RemoveAt(lsV_Jugadores.SelectedIndex);
        }

        private void btn_CambiarDatos_Click(object sender, RoutedEventArgs e)
        {
            Persona pTMP = lsV_Jugadores.SelectedItem as Persona;

            if (pTMP == null)
                return;
            int posicionP = lsV_Jugadores.SelectedIndex;
            CambiarNivel(pTMP);
            listitaPersonas.RemoveAt(posicionP);
            listitaPersonas.Insert(posicionP, pTMP);
        }

        private void CambiarNivel(Persona p)
        {
            try
            {
                p.Nivel = int.Parse(txtB_NivelPJ.Text);
            }
            catch
            {
                MessageBox.Show("Nuevos datos incompatibles");
            }
        }

        private void LimpiarTxtBoxes()
        {
            txtB_Nombre.Clear();
            txtB_NombrePJ.Clear();
            txtB_NivelPJ.Clear();

            txtB_Nombre.Focus();
        }
    }
}
