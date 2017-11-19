using Project.Models;
using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace Project.ViewModels {
    public class MainWindowViewModel : INotifyPropertyChanged {

        private static UserControl _currentControl;
        private static CustomerBase _customerBase;

        public string ACName {
            get { return _acName; }
            set {
                _acName = value;
                OnPropertyChanged(nameof(ACName));
            }
        }
        public string ACId {
            get { return _acId; }
            set {
                _acId = value;
                OnPropertyChanged(nameof(ACId));
            }
        }
        public string ACStreet {
            get { return _acStreet; }
            set {
                _acStreet = value;
                OnPropertyChanged(nameof(ACStreet));
            }
        }
        public string ACCity {
            get { return _acCity; }
            set {
                _acCity = value;
                OnPropertyChanged(nameof(ACCity));
            }
        }
        public string ACState {
            get { return _acState; }
            set {
                _acState = value;
                OnPropertyChanged(nameof(ACState));
            }
        }
        public string ACZipCode {
            get { return _acZipCode; }
            set {
                _acZipCode = value;
                OnPropertyChanged(nameof(ACZipCode));
            }
        }
        public string ACEmail {
            get { return _acEmail; }
            set {
                _acEmail = value;
                OnPropertyChanged(nameof(ACEmail));
            }
        }
        public string FCId {
            get { return _fcId; }
            set {
                _fcId = value;
                OnPropertyChanged(nameof(FCId));
            }
        }
        public string ECName {
            get { return _ecName; }
            set {
                _ecName = value;
                OnPropertyChanged(nameof(ECName));
            }
        }
        public string ECId {
            get { return _ecId; }
            set {
                _ecId = value;
                OnPropertyChanged(nameof(ECId));
            }
        }
        public string ECStreet {
            get { return _ecStreet; }
            set {
                _ecStreet = value;
                OnPropertyChanged(nameof(ECStreet));
            }
        }
        public string ECCity {
            get { return _ecCity; }
            set {
                _ecCity = value;
                OnPropertyChanged(nameof(ECCity));
            }
        }
        public string ECState {
            get { return _ecState; }
            set {
                _ecState = value;
                OnPropertyChanged(nameof(ECState));
            }
        }
        public string ECZipCode {
            get { return _ecZipCode; }
            set {
                _ecZipCode = value;
                OnPropertyChanged(nameof(ECZipCode));
            }
        }
        public string ECEmail {
            get { return _ecEmail; }
            set {
                _ecEmail = value;
                OnPropertyChanged(nameof(ECEmail));
            }
        }
        public string DCId {
            get { return _dcId; }
            set {
                _dcId = value;
                OnPropertyChanged(nameof(DCId));
            }
        }
        public string APNumber {
            get { return _apNumber; }
            set {
                _apNumber = value;
                OnPropertyChanged(nameof(APNumber));
            }
        }
        public string APCompany {
            get { return _apCompany; }
            set {
                _apCompany = value;
                OnPropertyChanged(nameof(APCompany));
            }
        }
        public string APMileage {
            get { return _apMileage; }
            set {
                _apMileage = value;
                OnPropertyChanged(nameof(APMileage));
            }
        }
        public string APSeatCapacity {
            get { return _apSeatCapacity; }
            set {
                _apSeatCapacity = value;
                OnPropertyChanged(nameof(APSeatCapacity));
            }
        }
        public string APWeightCapacity {
            get { return _apWeightCapacity; }
            set {
                _apWeightCapacity = value;
                OnPropertyChanged(nameof(APWeightCapacity));
            }
        }
        public string FPNumber {
            get { return _fpNumber; }
            set {
                _fpNumber = value;
                OnPropertyChanged(nameof(FPNumber));
            }
        }
        public string EPNumber {
            get { return _epNumber; }
            set {
                _epNumber = value;
                OnPropertyChanged(nameof(EPNumber));
            }
        }
        public string EPCompany {
            get { return _epCompany; }
            set {
                _epCompany = value;
                OnPropertyChanged(nameof(EPCompany));
            }
        }
        public string EPMileage {
            get { return _epMileage; }
            set {
                _epMileage = value;
                OnPropertyChanged(nameof(EPMileage));
            }
        }
        public string EPSeatCapacity {
            get { return _epSeatCapacity; }
            set {
                _epSeatCapacity = value;
                OnPropertyChanged(nameof(EPSeatCapacity));
            }
        }
        public string EPWeightCapacity {
            get { return _epWeightCapacity; }
            set {
                _epWeightCapacity = value;
                OnPropertyChanged(nameof(EPWeightCapacity));
            }
        }
        public string DPNumber {
            get { return _dpNumber; }
            set {
                _dpNumber = value;
                OnPropertyChanged(nameof(DPNumber));
            }
        }
        public string SPCustomer {
            get { return _spCustomer; }
            set {
                _spCustomer = value;
                OnPropertyChanged(nameof(SPCustomer));
            }
        }
        public string SPNumber {
            get { return _spNumber; }
            set {
                _spNumber = value;
                OnPropertyChanged(nameof(SPNumber));
            }
        }
        public string SPFrom {
            get { return _spFrom; }
            set {
                _spFrom = value;
                OnPropertyChanged(nameof(SPFrom));
            }
        }
        public string SPUntil {
            get { return _spUntil; }
            set {
                _spUntil = value;
                OnPropertyChanged(nameof(SPUntil));
            }
        }

        //AddCustomerControl textboxes
        private static string _acName;
        private static string _acId;  //int
        private static string _acStreet;
        private static string _acCity;
        private static string _acState;
        private static string _acZipCode; //int
        private static string _acEmail;

        //FindCustomerControl textbox
        private static string _fcId;

        //EditCustomerControl textboxes
        private static string _ecName;
        private static string _ecId;
        private static string _ecStreet;
        private static string _ecCity;
        private static string _ecState;
        private static string _ecZipCode;
        private static string _ecEmail;

        //DeleteCustomerControl textbox
        private static string _dcId;

        //AddCargoPlaneControl
        private static string _apNumber;
        private static string _apCompany;
        private static string _apMileage;
        private static string _apSeatCapacity;
        private static string _apWeightCapacity;

        //FindCargoPlaneControl
        private static string _fpNumber;

        

        //EditCargoPlaneControl
        private static string _epNumber;
        private static string _epCompany;
        private static string _epMileage;
        private static string _epSeatCapacity;
        private static string _epWeightCapacity;

        //DeleteCargoPlaneControl
        private static string _dpNumber;

        //ScheduleAPlaneControl
        private static string _spCustomer;
        private static string _spNumber;
        private static string _spFrom;
        private static string _spUntil;

        public MainWindowViewModel() {
            if (_customerBase == null)
                _customerBase = new CustomerBase();
        }

        public CustomerBase CustomerBase {
            get { return _customerBase; }
        }

        public UserControl CurrentControl {
            get {
                return _currentControl;
            }
            set {
                _currentControl = value;
                OnPropertyChanged(nameof(CurrentControl));
            }
        }

        public void AddCustomer(string name, int id, string street, string city, string state, int zipCode, string email) {
            Address address = new Address(street, city, state, zipCode);
            _customerBase.Add(new Customer(name, id, address, email));
        }

        public void AddCustomer() {
            Address address;
            if (Int32.TryParse(_acId, out int x) && Int32.TryParse(_acZipCode, out int y))
                address = new Address(_acStreet, _acCity, _acStreet, Int32.Parse(_acZipCode));
            else
                return;
            Customer customer = new Customer(_acName, Int32.Parse(_acId), address, _acEmail);
            _customerBase.Add(customer);
        }



        public int getCustomerBaseSize() {
            return _customerBase.getListSize();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
