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
            CloseWindowCommand = new RelayCommand(CloseWin);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public RelayCommand CloseWindowCommand { get; set; }

        public void CloseWin(object obj)
        {
            Window win = obj as Window;
            win.Close();
        }
    }
}