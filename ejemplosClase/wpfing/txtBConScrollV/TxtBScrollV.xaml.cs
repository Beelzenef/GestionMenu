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

namespace TxtBScrollV
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

        private void btn_MostrarDatos_Click(object sender, RoutedEventArgs e)
        {
            string[] lngsProg = { "Python", "C#", "Javascript", "XQuery", "XAML", "GO", "C++", "C", "Ruby"};

            for (int i = 0; i < lngsProg.Length; i++)
            {
                txtB_LoreIpsum.Text += lngsProg[i] + "\n";
            }
        }
    }
}
