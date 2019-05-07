using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using SpaceVikingsGUI.CloseWindow;
using SpaceVikingsGUI.Commands;
using SpaceVikingsGUI.Navigation;
using SpaceVikingsGUI.Views;

namespace SpaceVikingsGUI.ViewModels
{
    public class StoreViewModel : INotifyPropertyChanged, IViewModel
    {
        private readonly INavigation _navigation;

        public StoreViewModel(INavigation navigation)
        {
            _navigation = navigation;
            this.CloseWindowCommand = new RelayCommand<Window>(this.CloseWin);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public RelayCommand<Window> CloseWindowCommand { get; private set; }

        private void CloseWin(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }
    }
}