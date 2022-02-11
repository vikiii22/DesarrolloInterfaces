﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
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

namespace Ejercicio11
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public OleDbConnection miConexion;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string conectar = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =.\datos\libros.mdb";
            miConexion = new OleDbConnection(conectar);
            miConexion.Open();
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM editorial", miConexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            dgEditorial.ItemsSource = ds.Tables[0].DefaultView;
        }
    }
}
