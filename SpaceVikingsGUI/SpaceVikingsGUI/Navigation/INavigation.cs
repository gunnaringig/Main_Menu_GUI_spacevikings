using System.Windows;
using SpaceVikingsGUI.ViewModels;

namespace SpaceVikingsGUI.Navigation
{
    public interface INavigation
    {
        void Show(IViewModel viewModel);
        void Close(Window window);
    }
}