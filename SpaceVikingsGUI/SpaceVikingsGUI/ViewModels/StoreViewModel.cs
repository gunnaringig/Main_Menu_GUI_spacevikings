using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using SpaceVikingsGUI.Commands;
using SpaceVikingsGUI.Navigation;
using SpaceVikingsGUI.Views;

namespace SpaceVikingsGUI.ViewModels
{
    public class StoreViewModel : INotifyPropertyChanged, IViewModel
    {
        private readonly INavigation _navigation;
        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand CloseStoreWindowCommand { get; set; }


        public StoreViewModel(INavigation navigation)
        {
            _navigation = navigation;

            CloseStoreWindowCommand = new RelayCommand(OnStoreWindowClose);
        }

        private void OnStoreWindowClose()
        {
            Application.Current.Windows
                .OfType<Window>()
                .FirstOrDefault(window => window.IsActive)
                ?.Close();
        }
    }
}