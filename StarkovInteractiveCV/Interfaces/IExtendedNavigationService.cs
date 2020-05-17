using System.Threading.Tasks;
using Prism.Navigation;

namespace StarkovInteractiveCV.Interfaces
{
    public interface IExtendedNavigationService
    {
        Task<INavigationResult> GoBackAsync(INavigationParameters navigationParams = null, bool? useModelaNavigation = null, bool animated = true);
        Task<INavigationResult> NavigateAsync(string elementName, INavigationParameters navigationParams = null, bool? useModelaNavigation = null, bool animated = true);
    }
}
