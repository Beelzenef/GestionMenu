﻿using System;
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

namespace Tabs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int nTabs = 0;
        public MainWindow()
        {
            InitializeComponent();
            nTabs = tbC_Imagenes.Items.Count;
        }

        private void btn_Avanzar_Click(object sender, RoutedEventArgs e)
        {
            tbC_Imagenes.SelectedIndex++;
        }
    }
}