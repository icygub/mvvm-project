using Project.Models;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Project.ViewModels {
    class MainWindowViewModel : INotifyPropertyChanged {

        private UserControl _currentControl;
        

        public UserControl CurrentControl {
            get {
                return _currentControl;
            }
            set {
                _currentControl = value;
                OnPropertyChanged(nameof(CurrentControl));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
