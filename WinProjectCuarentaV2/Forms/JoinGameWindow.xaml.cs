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
using System.Windows.Shapes;
using System.Net;
using System.Net.Sockets;

namespace WinProjectCuarentaV2
{
    /// <summary>
    /// Interaction logic for JoinGameWindow.xaml
    /// </summary>
    public partial class JoinGameWindow : Window
    {
        bool usuario;
        string ip;
        //Client prueba;
        public JoinGameWindow(bool estado)
        {
            InitializeComponent();
            usuario = estado;
        }

        private void btnJoin_Click(object sender, RoutedEventArgs e)
        {
            ip = txtIp.Text;
            //prueba = new Client(ip);
            WindowsCuarenta w = new WindowsCuarenta(false, ip,4,1);
            this.Close();
            w.Show();
        }
    }
}
