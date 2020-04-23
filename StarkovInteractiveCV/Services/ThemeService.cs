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
            SetThemeResources(theme);
            _settingsService.StyleTheme = theme;
            _nativeThemeService.SetTheme(theme);
        }

        public void SetThemeResources(StyleTheme theme)
        {
            if (theme == StyleTheme.Light)
                App.Current.Resources = new LightTheme();
            else
                App.Current.Resources = new DarkTheme();
        }

        public void SwitchTheme()
        {
            switch (CurrentTheme)
            {
                case StyleTheme.Dark:
                    SetTheme(StyleTheme.Light);
                    break;
                case StyleTheme.Light:
                    SetTheme(StyleTheme.Dark);
                    break;
            }
        }
    }
}
