using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppW_LoginUsuario
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        VentanaSaludo loginCorrecto;

        public MainWindow()
        {
            InitializeComponent();
            loginCorrecto = new VentanaSaludo();
        }

        string PASSCORRECTA = "lol";
        string USERCORRECTO = "Beel";

        int NINTENTOSMAXIMOS = 3;
        int nIntentos = 0;

        private void btn_Aceptar_Click(object sender, RoutedEventArgs e)
        {
            nIntentos++;

            if (txtB_NombreUsuario.Text == USERCORRECTO && passB_ClaveUsuario.Password == PASSCORRECTA)
            {
                loginCorrecto.ShowDialog();
                lbl_Info.Content = "¡Correcto!";
            }
            else
                lbl_Info.Content = "Datos incorrectos";

            if (nIntentos == NINTENTOSMAXIMOS)
            {
                btn_Aceptar.IsEnabled = false;
                lbl_Info.Content = "Login cancelado";
            }
        }

        private void btn_Reset_Click(object sender, RoutedEventArgs e)
        {
            passB_ClaveUsuario.Clear();
            txtB_NombreUsuario.Clear();

            txtB_NombreUsuario.Focus();
        }

        private void txtB_NombreUsuario_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtB_NombreUsuario.Text.Length == 0)
            {
                txtB_NombreUsuario.Foreground = Brushes.Gray;
                txtB_NombreUsuario.Text = "Tu usuario";
            }
        }

        private void txtB_NombreUsuario_GotFocus(object sender, RoutedEventArgs e)
        {
            txtB_NombreUsuario.Clear();
            txtB_NombreUsuario.Foreground = Brushes.Black;
        }

        private void passB_ClaveUsuario_GotFocus(object sender, RoutedEventArgs e)
        {
            passB_ClaveUsuario.Clear();
        }
    }
}
