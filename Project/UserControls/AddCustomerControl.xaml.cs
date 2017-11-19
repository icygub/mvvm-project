using Project.ViewModels;
using System;
using System.Windows.Controls;

namespace Project.UserControls {
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomerControl : UserControl {

        private static MainWindowViewModel _model;

        public AddCustomerControl() {
            InitializeComponent();
            _model = new MainWindowViewModel();
            DataContext = _model;
        }

        private void BtnAddCustomer_Click(object sender, System.Windows.RoutedEventArgs e) {
            _model.AddCustomer();
            
        }
    }
}
