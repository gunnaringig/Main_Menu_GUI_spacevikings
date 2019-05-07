using SpaceVikingsGUI.Navigation;
using SpaceVikingsGUI.ViewModels;

namespace SpaceVikingsGUI.Locator
{
    public class ViewModelLocator
    {
        private readonly INavigation _navigation = new NavigationService();

        public LoginViewModel LoginViewModel => new LoginViewModel(_navigation);
    }
}