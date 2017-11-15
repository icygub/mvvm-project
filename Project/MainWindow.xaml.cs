using Project.UserControls;
using Project.ViewModels;
using System.Windows;

namespace Project {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private MainWindowViewModel _viewModel;

        public MainWindow() {
            InitializeComponent();
            _viewModel = new MainWindowViewModel();
            DataContext = _viewModel;
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = new TestControl2();
        }

        private void btnFindCustomer_Click(object sender, RoutedEventArgs e) {
            _viewModel.CurrentControl = new TestControl();
        }
    }
}
