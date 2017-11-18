using Project.UserControls;
using Project.ViewModels;
using System.Windows;

namespace Project {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private static MainWindowViewModel _viewModel;
        private static AddCustomerControl _addCustomerControl;
        private static FindCustomerControl _findCustomerControl;
        private static EditCustomerControl _editCustomerControl;
        private static DeleteCustomerControl _deleteCustomerControl;
        private static AddCargoPlaneControl _addCargoPlaneControl;
        private static FindCargoPlaneControl _findCargoPlaneControl;
        private static EditCargoPlaneControl _editCargoPlaneControl;
        private static DeleteCargoPlaneControl _deleteCargoPlaneControl;
        private static ScheduleACargoPlaneControl _scheduleACargoPlaneControl;
        private static ViewSchedulesControl _viewSchedulesControl;

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
