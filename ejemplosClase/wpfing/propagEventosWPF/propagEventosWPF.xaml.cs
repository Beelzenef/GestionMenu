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

namespace ejemploEventos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            tBl_Coordenadas.Text = "(" + e.GetPosition(this).X + "," + e.GetPosition(this).Y + ") - " + e.Source.GetType().Name;
        }

        private void img_Earth_MouseMove(object sender, MouseEventArgs e)
        {
            e.Handled = true;
        }
    }
}
