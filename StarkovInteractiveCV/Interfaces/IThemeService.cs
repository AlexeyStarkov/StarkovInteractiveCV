using StarkovInteractiveCV.Enums;

namespace StarkovInteractiveCV.Interfaces
{
    public interface IThemeService
    {
        StyleTheme CurrentTheme { get; }
        void SetTheme(StyleTheme theme);
        void SetThemeResources(StyleTheme theme);
        void SwitchTheme();
    }
}
