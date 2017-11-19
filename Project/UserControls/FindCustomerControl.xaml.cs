using Project.Models;
using Project.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace Project.UserControls {
    /// <summary>
    /// Interaction logic for FindCustomerControl.xaml
    /// </summary>
    public partial class FindCustomerControl : UserControl {

        private static MainWindowViewModel _model;

        public FindCustomerControl() {
            InitializeComponent();
            _model = new MainWindowViewModel();
            DataContext = _model;
        }

        private void BtnFindCustomer_Click(object sender, RoutedEventArgs e) {
            int id;
            Customer customer;
            try {
                id = Int32.Parse(TxtBxSearchById.Text);
                customer = (Customer)_model.CustomerBase.Find(id); //TxtBxSearchById

            } catch {
                return;
            }

            TxtBlkDisplayFoundCustomer.Text = String.Format("Name: {0}\n" +
                                                            "Street: {1}\n" +
                                                            "City: {2}\n" +
                                                            "State: {3}\n" +
                                                            "Zip: {4}\n" +
                                                            "Email: {5}",
                                                            customer.Name, customer.Address.Street, customer.Address.City,
                                                            customer.Address.State, customer.Address.ZipCode, customer.Email);

        }
    }
}
