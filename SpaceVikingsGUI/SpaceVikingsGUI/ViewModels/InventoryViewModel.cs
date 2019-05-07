using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using SpaceVikingsGUI.Commands;
using SpaceVikingsGUI.Navigation;
using SpaceVikingsGUI.Services;

namespace SpaceVikingsGUI.ViewModels
{
    public class InventoryViewModel : INotifyPropertyChanged, IViewModel
    {
        private readonly INavigation _navigation;
        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand CloseInventoryWindowCommand { get; set; }
        

        public InventoryViewModel(INavigation navigation)
        {
            _navigation = navigation;

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