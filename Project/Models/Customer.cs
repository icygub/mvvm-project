
using System.ComponentModel;

namespace Project.Models {
    public class Customer : BaseObject, INotifyPropertyChanged {

        private string _name;
        private Address _address;
        private string _email;

        public Customer(string name, int id) : base(id) {
            this.Name = name;
        }

        public Customer(string name, int id, Address address, string email) : base(id) {
            this.Name = name;
            this.Address = address;
            this.Email = email;
        }

        public string Name {
            get { return _name; }
            set {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public Address Address {
            get { return _address; }
            set {
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }

        public string Email {
            get { return _email; }
            set {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class Address {
        public Address(string street, string city, string state, int zipCode) {
            this.Street = street;
            this.City = city;
            this.State = state;
            this.ZipCode = zipCode;
        }

        public string Street {
            get; set;
        }

        public string City {
            get; set;
        }

        public string State {
            get; set;
        }

        public int ZipCode {
            get; set;
        }
    }
}
