using Project.ViewModels;
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
    /// Interaction logic for FindCargoPlaneControl.xaml
    /// </summary>
    public partial class FindCargoPlaneControl : UserControl
    {

        private static MainWindowViewModel _model;

        public FindCargoPlaneControl()
        {
            InitializeComponent();
            DataContext = _model;
        }

        private void BtnFindPlane_Click(object sender, RoutedEventArgs e) {

        }
    }
}
