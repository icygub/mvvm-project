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
    /// Interaction logic for DeleteCargoPlaneControl.xaml
    /// </summary>
    public partial class DeleteCargoPlaneControl : UserControl
    {
        private static MainWindowViewModel _model;

        public DeleteCargoPlaneControl()
        {
            InitializeComponent();
            DataContext = _model;
        }

        private void BtnDeletePlane_Click(object sender, RoutedEventArgs e) {

        }
    }
}
