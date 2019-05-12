using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using SpaceVikingsGUI.Commands;
using SpaceVikingsGUI.Navigation;
using SpaceVikingsGUI.Services;
using BifrostClient;
using System.IO;
using SpaceVikingsGUI.APIConsumption;

namespace SpaceVikingsGUI.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged, IViewModel
    {
        private readonly INavigation _navigation;
        private readonly ILogin _login;
        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand OpenStoreView { get; set; }
        public RelayCommand OpenInventoryView { get; set; }
        public RelayCommand CloseApplicationCommand { get; set; }
        public RelayCommand ResizeCommand { get; set; }
        public RelayCommand startGame { get; set; }
        private bool waitingForGame = false;

        public MainViewModel(INavigation navigation, ILogin login)
        {
            _navigation = navigation;
            _login = login;

            OpenStoreView = new RelayCommand(OnOpenStoreView);
            OpenInventoryView = new RelayCommand(OnOpenInventoryView);
            CloseApplicationCommand = new RelayCommand(OnApplicationClose);
            ResizeCommand = new RelayCommand(resize);
            startGame = new RelayCommand(StartGameEvent);
        }

        private void OnOpenStoreView()
        {
            _navigation.Show(new StoreViewModel(_navigation, _login));
        }

        private void OnOpenInventoryView()
        {
            _navigation.Show(new InventoryViewModel(_navigation, _login));
        }

        private void StartGameEvent() {
            if (!waitingForGame) {
                // yes this is a spaghetti hack
                waitingForGame = true;
            var cli = new Client();
                cli.SetGUIMode();
                // awaits swarm change ! note to GUI devs, set button to a disabled state, above is only a hack
                cli.OnSwarmReady += (Guid ClientId) =>
                {
                    var process = new Process
                    {
                        StartInfo =
                          {
                              FileName = Path.Combine(Environment.CurrentDirectory, @"Data\GameBinaries\", $"Movement.exe"),
                              Arguments = $"-spToken {ClientId}"
                          }
                    };
                    process.Start();
                };
                cli.Start();
            }
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