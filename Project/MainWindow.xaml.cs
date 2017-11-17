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
        private AddCargoPlaneControl _addCargoPlaneControl;
        private FindCargoPlaneControl _findCargoPlaneControl;
        private EditCargoPlaneControl _editCargoPlaneControl;
        private DeleteCargoPlaneControl _deleteCargoPlaneControl;
        private ScheduleACargoPlaneControl _scheduleACargoPlaneControl;
        private ViewSchedulesControl _viewSchedulesControl;

        public MainWindow() {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            _addCustomerControl = new AddCustomerControl();
            _findCustomerControl = new FindCustomerControl();
            _editCustomerControl = new EditCustomerControl();
            _deleteCustomerControl = new DeleteCustomerControl();
            _addCargoPlaneControl = new AddCargoPlaneControl();
            _findCargoPlaneControl = new FindCargoPlaneControl();
            _editCargoPlaneControl = new EditCargoPlaneControl();
            _deleteCargoPlaneControl = new DeleteCargoPlaneControl();
            _scheduleACargoPlaneControl = new ScheduleACargoPlaneControl();
            _viewSchedulesControl = new ViewSchedulesControl();
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

        private void btnAddCargoPlane_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _addCargoPlaneControl;
        }

        private void btnFindCargoPlane_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _findCargoPlaneControl;
        }

        private void btnEditCargoPlane_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _editCargoPlaneControl;
        }

        private void btnDeleteCargoPlane_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _deleteCargoPlaneControl;
        }

        private void btnScheduleCargoPlane_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _scheduleACargoPlaneControl;
        }

        private void btnViewSchedules_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = _viewSchedulesControl;                                              
        }
    }
}
