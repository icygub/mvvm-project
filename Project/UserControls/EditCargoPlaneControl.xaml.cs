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

namespace Project.UserControls
{
    /// <summary>
    /// Interaction logic for EditCargoPlaneControl.xaml
    /// </summary>
    public partial class EditCargoPlaneControl : UserControl
    {
        private static MainWindowViewModel _model;

        public EditCargoPlaneControl()
        {
            InitializeComponent();
            DataContext = _model;
        }

        private void BtnEditPlane_Click(object sender, RoutedEventArgs e) {

        }
    }
}
