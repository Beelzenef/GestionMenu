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

namespace ControlandoGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gridPrueba.ShowGridLines = true;
        }

        private void btn_ModGrid_Click(object sender, RoutedEventArgs e)
        {
            ColumnDefinition c1 = new ColumnDefinition();
            ColumnDefinition c2 = new ColumnDefinition();
            RowDefinition r1 = new RowDefinition();
            RowDefinition r2 = new RowDefinition();

            gridPrueba.ColumnDefinitions.Add(c1);
            gridPrueba.ColumnDefinitions.Add(c2);
            gridPrueba.RowDefinitions.Add(r1);
            gridPrueba.RowDefinitions.Add(r2);

            Button b = new Button();
            b.Content = "Botoncito";

            b.Click += botoncito_Click;

            Grid.SetRow(b, 2);
            Grid.SetColumn(b, 1);

            gridPrueba.Children.Add(b);
        }

        private void botoncito_Click(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "weee";
        }

        private void btn_Vaciar_Click(object sender, RoutedEventArgs e)
        {
            gridPrueba.Children.Clear();
        }
    }
}
