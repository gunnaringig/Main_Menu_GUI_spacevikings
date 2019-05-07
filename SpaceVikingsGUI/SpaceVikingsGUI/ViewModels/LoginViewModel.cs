using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using SpaceVikingsGUI.Commands;
using SpaceVikingsGUI.Data.Users;
using SpaceVikingsGUI.Navigation;
using SpaceVikingsGUI.Services;
using SpaceVikingsGUI.Views;

namespace SpaceVikingsGUI.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged, IViewModel
    {
        private string _username;
        private string _password;
        private string _errorMessage;
        private PasswordBox _boxRef;

        private readonly INavigation _navigation;
        private readonly Service.IService<IUser, IUser> _userService;

        public LoginViewModel(INavigation navigation)
        {
            _navigation = navigation;
            _userService = Service.ServiceFactory.CreateUserService();

            LoginCommand = new RelayCommand(OnLogin, CanLogin);
            PasswordChangedCommand = new RelayCommand<PasswordBox>(OnPasswordChanged);
            CloseApplicationCommand = new RelayCommand(OnApplicationClose);
            AddUserCommand = new RelayCommand(OnAddUser, CanAddUser);
        }

        private bool CanLogin() => !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
        private bool CanAddUser() => true;

        private void OnAddUser()
        {
            IUser user = new User() { Email = Username, Password = Password };

            try
            {
                user = _userService.Add(user);

                ClearInputFields();

                ErrorMessage = $"Welcome {user.Email}!";
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }

        }

        private void ClearInputFields()
        {
            _boxRef.Password = string.Empty;
            Username = string.Empty;
        }

        private void OnLogin()
        {
            IUser user = new User() { Email = Username, Password = Password };

            try
            {
                user = _userService.Get(user);
                _navigation.Close(new MainWindow());
                _navigation.Show(new MainViewModel(_navigation));
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }

        private void OnApplicationClose()
        {
            Application.Current.Shutdown();
        }

        private void OnPasswordChanged(PasswordBox box)
        {
            _boxRef = box;
            Password = _boxRef?.Password;
        }

        public RelayCommand<PasswordBox> PasswordChangedCommand { get; set; }
        public RelayCommand AddUserCommand { get; set; }
        public RelayCommand CloseApplicationCommand { get; set; }
        public RelayCommand LoginCommand { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public string ErrorMessage
        {
            get => _errorMessage;
            set
            {
                if (_errorMessage == value) return;
                _errorMessage = value;
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(ErrorMessage)));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                if (_password == value) return;
                _password = value;
                LoginCommand.RaiseCanExecuteChanged();
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Password)));
            }
        }
        public string Username
        {
            get => _username;
            set
            {
                if (_username == value) return;
                _username = value;
                LoginCommand.RaiseCanExecuteChanged();
                PropertyChanged(this, new PropertyChangedEventArgs(nameof(Username)));

            }
        }
    }
}