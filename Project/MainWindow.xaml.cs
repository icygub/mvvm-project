using Project.UserControls;
using System.Windows;

namespace Project {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            TestControl2 testControl2 = new TestControl2();
            contentControl.Content = testControl2;
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e) {         
            this.contentControl.Content = new TestControl();
            
        }
    }
}
