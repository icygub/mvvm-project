using Project.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Project.ViewModels {
    class MainWindowViewModel : INotifyPropertyChanged {

        private static UserControl _currentControl;
        private static string _name;
        
        public UserControl CurrentControl {
            get {
                return _currentControl;
            }
            set {
                _currentControl = value;
                OnPropertyChanged(nameof(CurrentControl));
            }
        }

        public string Name {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged(nameof(Name));
                MessageBox.Show(_name);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
