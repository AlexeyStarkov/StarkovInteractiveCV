using System.Threading.Tasks;
using Prism.Navigation;
using StarkovInteractiveCV.Interfaces;

namespace StarkovInteractiveCV.Services
{
    public class ExtendedNavigationService : IExtendedNavigationService
    {
        private readonly INavigationService _navigationService;

        private bool _isNavigating;

        public ExtendedNavigationService(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public async Task<INavigationResult> GoBackAsync(INavigationParameters navigationParams = null, bool? useModelaNavigation = null, bool animated = true)
        {
            if (!_isNavigating)
            {
                _isNavigating = true;
                var navigationResult = await _navigationService.GoBackAsync(navigationParams, useModelaNavigation, animated);
                _isNavigating = false;
                return navigationResult;
            }

            return new NavigationResult() { Success = false };
        }

        public async Task<INavigationResult> NavigateAsync(string elementName, INavigationParameters navigationParams = null, bool? useModelaNavigation = null, bool animated = true)
        {
            if (!_isNavigating)
            {
                _isNavigating = true;
                var navigationResult = await _navigationService.NavigateAsync(elementName, navigationParams, useModelaNavigation, animated);
                _isNavigating = false;
                return navigationResult;
            }

            return new NavigationResult() { Success = false };
        }
    }
}
