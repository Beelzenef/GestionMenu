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
using System.Windows.Shapes;

namespace commCurrent
{
    /// <summary>
    /// Interaction logic for winDestino.xaml
    /// </summary>
    public partial class winDestino : Window
    {
        public winDestino()
        {
            InitializeComponent();
        }

        private void btn_MensajeDeVuelta_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn_Salida_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btn_MostrarTexto_Click(object sender, RoutedEventArgs e)
        {
            txtB_ContenedorDestino.Text = (Application.Current as App).Dato;
        }
    }
}
