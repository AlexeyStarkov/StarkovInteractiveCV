using StarkovInteractiveCV.Enums;

namespace StarkovInteractiveCV.Interfaces
{
    public interface IThemeService
    {
        StyleTheme CurrentTheme { get; }
        void SetTheme(StyleTheme theme);
    }
}
