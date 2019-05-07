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
    public class MainViewModel : INotifyPropertyChanged, IViewModel
    {
        private readonly INavigation _navigation;
        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand OpenStoreView { get; set; }
        public RelayCommand OpenInventoryView { get; set; }
        public RelayCommand CloseApplicationCommand { get; set; }


        public MainViewModel(INavigation navigation)
        {
            _navigation = navigation;

            OpenStoreView = new RelayCommand(OnOpenStoreView);
            OpenInventoryView = new RelayCommand(OnOpenInventoryView);
            CloseApplicationCommand = new RelayCommand(OnApplicationClose);

        }

        private void OnOpenStoreView()
        {
            _navigation.Show(new StoreViewModel(_navigation));
        }

        private void OnOpenInventoryView()
        {
            _navigation.Show(new InventoryViewModel(_navigation));
        }

        private void OnApplicationClose()
        {
            Application.Current.Shutdown();
        }

    }
}