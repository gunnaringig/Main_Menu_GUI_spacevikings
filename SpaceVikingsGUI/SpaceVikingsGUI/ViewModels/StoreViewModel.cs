using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using SpaceVikingsGUI.Commands;
using SpaceVikingsGUI.Navigation;

namespace SpaceVikingsGUI.ViewModels
{
    public class StoreViewModel : INotifyPropertyChanged, IViewModel
    {
        private readonly INavigation _navigation;

        public StoreViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}