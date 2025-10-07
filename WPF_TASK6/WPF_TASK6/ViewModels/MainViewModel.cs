using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_TASK6.Models;

namespace WPF_TASK6.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<User> Users { get; } = new()
        {
            new User { Name = "Elis", Email = "elis@gmail.com", Age = 20 },
            new User { Name = "Nick", Email = "nick@gmail.com", Age = 29 },
            new User { Name = "Alex", Email = "alex@gmail.com", Age = 44 },
        };

        private User? _selectedUser;
        public User? SelectedUser
        {
            get => _selectedUser;
            set { if (!ReferenceEquals(_selectedUser, value)) { _selectedUser = value; OnChanged(nameof(SelectedUser)); } }
        }

        public MainViewModel()
        {
            if (Users.Count > 0 )
            {
                SelectedUser = Users[0];
            }
        }

        public void AddUser()
        {
            var user = new User { Name = "Alan", Email = "alan@gmail.com", Age = 20 };

            Users.Add(user);
            SelectedUser = user;
        }

        public void RemoveSelectedUser()
        {
            if (SelectedUser != null)
            {
                var idx = Users.IndexOf(SelectedUser);
                Users.Remove(SelectedUser);

                SelectedUser = Users.Count > 0 ? Users[Math.Clamp(idx - 0, 0, Users.Count - 1)] : null;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnChanged(string n) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(n));
    }
}
