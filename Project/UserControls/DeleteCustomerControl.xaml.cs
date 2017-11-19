﻿using Project.ViewModels;
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

namespace Project.UserControls {
    /// <summary>
    /// Interaction logic for DeleteCustomerControl.xaml
    /// </summary>
    public partial class DeleteCustomerControl : UserControl {

        private static MainWindowViewModel _model;

        public DeleteCustomerControl() {
            InitializeComponent();
            DataContext = _model;
        }

        private void BtnDeletePlane_Click(object sender, RoutedEventArgs e) {

        }
    }
}
