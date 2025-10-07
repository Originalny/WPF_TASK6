using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_TASK6.Models
{
    public class User : INotifyPropertyChanged
    {
        private string _name = "";
        private string _email = "";
        private int _age;

        public string Name
        {
            get => _name;
            set { if (_name != value) { _name = value; OnChanged(nameof(Name)); } }
        }

        public string Email
        {
            get => _email;
            set { if (_email != value) { _email = value; OnChanged(nameof(Email)); } }
        }

        public int Age
        {
            get => _age;
            set { if (_age != value) { _age = value; OnChanged(nameof(Age)); } }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnChanged(string n) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));
    }
}
