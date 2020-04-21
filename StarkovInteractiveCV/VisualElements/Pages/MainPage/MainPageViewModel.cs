using System.Windows.Input;
using Prism.Navigation;
using StarkovInteractiveCV.Enums;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.MainPage
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IThemeService _themeService;

        public ICommand ChangeThemeCommand => new Command(async (parameter) =>
        {
            if (_themeService.CurrentTheme == StyleTheme.Light)
            {
                _themeService.SetTheme(StyleTheme.Dark);
            }
            else
            {
                _themeService.SetTheme(StyleTheme.Light);
            }
        });

        public MainPageViewModel(INavigationService navigationService, IThemeService themeService)
            : base(navigationService)
        {
            _themeService = themeService;
        }
    }
}
