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

        public RelayCommand OpenStoreView { get; set; }

        public MainViewModel(INavigation navigation)
        {
            _navigation = navigation;

            OpenStoreView = new RelayCommand(OnOpenStoreView);
        }

        private void OnOpenStoreView()
        {
            _navigation.Show(new StoreViewModel(_navigation));
        }

        private void OnCloseMealSelection()
        {
            Application.Current.Windows
                .OfType<Window>()
                .FirstOrDefault(window => window.IsActive)
                ?.Close();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };


        public RelayCommand RecipeSelectionCommand { get; set; }
        public RelayCommand<string> BookSelectionCommand { get; set; }
        public RelayCommand CloseMealSelectionCommand { get; set; }

        public RelayCommand AddToMealplanCommand { get; set; }

    }
}