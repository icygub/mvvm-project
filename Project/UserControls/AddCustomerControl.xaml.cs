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
            //string name = TxtBxCustomerName.Text;
            //int id = Int32.Parse(TxtBxCustomerId.Text);
            //string street = TxtBxCustomerStreet.Text;
            //string city = TxtBxCustomerCity.Text;
            //string state = TxtBxCustomerState.Text;
            //int zipCode = Int32.Parse(TxtBxCustomerZip.Text);
            //string email = TxtBxCustomerEmail.Text;
            //_model.AddCustomer(name, id, street, city, state, zipCode, email);
        }
    }
}
