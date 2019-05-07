using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using SpaceVikingsGUI.CloseWindow;
using SpaceVikingsGUI.Commands;
using SpaceVikingsGUI.Navigation;
using SpaceVikingsGUI.Services;

namespace SpaceVikingsGUI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged, IViewModel
    {
        private readonly INavigation _navigation;

        public RelayCommand OpenStoreView { get; set; }

        public MainViewModel(INavigation navigation)
        {
            _navigation = navigation;

            OpenStoreView = new RelayCommand(OnOpenStoreView);
            //CloseWindowCommand = new RelayCommand<IClose>(this.CloseWindow);
            CloseApplicationCommand = new RelayCommand(OnApplicationClose);

        }

        public RelayCommand CloseApplicationCommand { get; set; }

        private void OnOpenStoreView()
        {
            _navigation.Show(new StoreViewModel(_navigation));
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public RelayCommand<IClose> CloseWindowCommand { get; private set; }

        //private void CloseWindow(IClose window)
        //{
        //    if (window != null)
        //    {
        //        window.Close();
        //    }
        //}

        private void OnApplicationClose()
        {
            Application.Current.Shutdown();
        }

    }
}