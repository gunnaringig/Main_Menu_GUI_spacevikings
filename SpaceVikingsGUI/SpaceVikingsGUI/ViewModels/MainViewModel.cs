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
        public RelayCommand ResizeCommand { get; set; }


        public MainViewModel(INavigation navigation)
        {
            _navigation = navigation;

            OpenStoreView = new RelayCommand(OnOpenStoreView);
            OpenInventoryView = new RelayCommand(OnOpenInventoryView);
            CloseApplicationCommand = new RelayCommand(OnApplicationClose);
            ResizeCommand = new RelayCommand(resize);
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

        private void resize()
        {
            Application.Current.MainWindow.Height = 600;
            Application.Current.MainWindow.Width = 600;
        }

    }
}