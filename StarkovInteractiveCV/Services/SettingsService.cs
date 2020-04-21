using StarkovInteractiveCV.Enums;
using StarkovInteractiveCV.Interfaces;
using Xamarin.Essentials;

namespace StarkovInteractiveCV.Services
{
    public class SettingsService : ISettingsService
    {
        public StyleTheme StyleTheme
        {
            get => (StyleTheme)Preferences.Get(nameof(StyleTheme), 0);
            set => Preferences.Set(nameof(StyleTheme), (int)value);
        }
    }
}
