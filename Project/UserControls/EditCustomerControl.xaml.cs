using Project.ViewModels;
using System;
using System.Windows.Controls;


namespace Project.UserControls {
    /// <summary>
    /// Interaction logic for EditCustomer.xaml
    /// </summary>
    public partial class EditCustomerControl : UserControl {

        private static MainWindowViewModel _model;

        public EditCustomerControl() {
            InitializeComponent();
            _model = new MainWindowViewModel();
            DataContext = _model;
        }

        private void BtnEditCustomer_Click(object sender, System.Windows.RoutedEventArgs e) {
            
        }
    }
}
