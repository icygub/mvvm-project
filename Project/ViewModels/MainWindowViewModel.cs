using Project.Models;
using System.ComponentModel;
using System.Windows.Controls;

namespace Project.ViewModels {
    class MainWindowViewModel : INotifyPropertyChanged {

        private UserControl _currentControl;
        public event PropertyChangedEventHandler PropertyChanged;

        public UserControl CurrentControl {
            get {
                return _currentControl;
            }
            set {
                _currentControl = value;
                OnPropertyChanged(nameof(CurrentControl));
            }
        }

        private void OnPropertyChanged(string propertyName) {
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
