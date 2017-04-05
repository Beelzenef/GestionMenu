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

using System.ComponentModel;

namespace AppW_OrdenandoSelectores
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

        private void cmB_Ordenacion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lsB_ListaJuegos.Items.SortDescriptions.Clear();
            if (cmB_Ordenacion.SelectedIndex == 0)
                lsB_ListaJuegos.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Ascending));
            else
                lsB_ListaJuegos.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Descending));
        }
    }
}
