using Project.UserControls;
using Project.ViewModels;
using System.Windows;

namespace Project {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private MainWindowViewModel _viewModel;
        private AddCustomerControl _addCustomerControl;
        private FindCustomerControl _findCustomerControl;
        private EditCustomerControl _editCustomerControl;
        private DeleteCustomerControl _deleteCustomerControl;

        public MainWindow() {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            _addCustomerControl = new AddCustomerControl();
            _findCustomerControl = new FindCustomerControl();
            _editCustomerControl = new EditCustomerControl();
            _deleteCustomerControl = new DeleteCustomerControl();
            DataContext = _viewModel;
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _addCustomerControl;
        }

        private void btnFindCustomer_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _findCustomerControl;
        }

        private void btnEditCustomer_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _editCustomerControl;
        }

        private void btnDeleteCustomer_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _deleteCustomerControl;
        }
    }
}
