using StarkovInteractiveCV.Enums;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.Styles;
using Xamarin.Forms;

namespace StarkovInteractiveCV.Services
{
    public class ThemeService : IThemeService
    {
        private readonly ISettingsService _settingsService;
        private readonly INativeThemeService _nativeThemeService;

        public StyleTheme CurrentTheme => _settingsService.StyleTheme;

        public ThemeService(ISettingsService settingsService)
        {
            _settingsService = settingsService;
            _nativeThemeService = DependencyService.Resolve<INativeThemeService>();
        }

        public void SetTheme(StyleTheme theme)
        {
            if (theme == StyleTheme.Light)
                App.Current.Resources = new LightTheme();
            else
                App.Current.Resources = new DarkTheme();

            _settingsService.StyleTheme = theme;
            _nativeThemeService.SetTheme(theme);
        }
    }
}
