using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using SpaceVikingsGUI.APIConsumption;
using SpaceVikingsGUI.Commands;
using SpaceVikingsGUI.Navigation;
using SpaceVikingsGUI.Services;

namespace SpaceVikingsGUI.ViewModels
{
    public class InventoryViewModel : INotifyPropertyChanged, IViewModel
    {
        private readonly INavigation _navigation;
        private readonly ILogin _login;
        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand CloseInventoryWindowCommand { get; set; }
        

        public InventoryViewModel(INavigation navigation, ILogin login)
        {
            _navigation = navigation;
            _login = login;

            CloseInventoryWindowCommand = new RelayCommand(OnInventoryClose);
        }

        private void OnInventoryClose()
        {
            Application.Current.Windows
                .OfType<Window>()
                .FirstOrDefault(window => window.IsActive)
                ?.Close();
        }
    }
}