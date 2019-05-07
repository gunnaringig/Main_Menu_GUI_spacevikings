using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SpaceVikingsGUI.Navigation;
using SpaceVikingsGUI.ViewModels;
using SpaceVikingsGUI.Views;

namespace SpaceVikingsGUI.Navigation
{
    public class NavigationService : INavigation
    {
        private const string Main = "SpaceVikingsGUI.ViewModels.MainViewModel";
        private const string Store = "SpaceVikingsGUI.ViewModels.StoreViewModel";
        private const string Inventory = "SpaceVikingsGUI.ViewModels.InventoryViewModel";

        public void Show(IViewModel viewModel)
        {

            switch (viewModel.GetType().FullName)
            {
                case Main:
                    ShowWindow(viewModel, new MainView());
                    break;

                case Store:
                    ShowWindow(viewModel, new StoreView());
                    break;

                case Inventory:
                    ShowWindow(viewModel, new InventoryView());
                    break;

                default:
                    break;
            }
        }

        public void Close(Window window)
        {
            Application.Current.Windows.OfType<Window>().FirstOrDefault(w => w.IsActive && w.Title == window.Title)?.Close();
        }

        private void ShowWindow(IViewModel viewModel, UserControl view)
        {
            view.DataContext = viewModel;
            Window(view).Show();
        }

        private Window Window(UserControl view)
        {
            return new Window()
            {
                Title = "No Title",
                Content = view,
                WindowStartupLocation = WindowStartupLocation.Manual,
                ResizeMode = ResizeMode.NoResize,
                WindowStyle = WindowStyle.None,
                SizeToContent = SizeToContent.Manual,
                WindowState = WindowState.Normal,
                AllowDrop = true,
                MaxHeight = 600,
                MaxWidth = 1024
            };
        }
    }
}