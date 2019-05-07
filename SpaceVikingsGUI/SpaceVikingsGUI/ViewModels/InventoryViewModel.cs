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
        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        private readonly INavigation _navigation;

        public InventoryViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }
    }
}