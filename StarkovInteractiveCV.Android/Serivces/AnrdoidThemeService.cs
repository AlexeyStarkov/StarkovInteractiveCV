using StarkovInteractiveCV.Droid.Serivces;
using StarkovInteractiveCV.Enums;
using StarkovInteractiveCV.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(AnrdoidThemeService))]
namespace StarkovInteractiveCV.Droid.Serivces
{
    public class AnrdoidThemeService : INativeThemeService
    {
        public void SetTheme(StyleTheme theme)
        {
            MainActivity.Instance.SetStyleTheme(theme);
        }
    }
}
