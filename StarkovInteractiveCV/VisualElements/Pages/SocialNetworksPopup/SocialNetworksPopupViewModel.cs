using System.Windows.Input;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.Helpers;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.SocialNetworksPopup
{
    public class SocialNetworksPopupViewModel : ViewModelBase
    {
        public ICommand OpenLinkedInCommand => new Command(async (parameter) =>
        {
            var isDeepLinkingPossible = await Launcher.CanOpenAsync(Constants.LinkedInDeepLink);
            if (isDeepLinkingPossible)
                await Launcher.OpenAsync(Constants.LinkedInDeepLink);
            else
                await Launcher.OpenAsync(Constants.LinkedInWebUrl);
        });

        public ICommand OpenFacebookCommand => new Command(async (parameter) =>
        {
            var isDeepLinkingPossible = await Launcher.CanOpenAsync(Constants.FacebookDeepLink);
            if (isDeepLinkingPossible)
                await Launcher.OpenAsync(Constants.FacebookDeepLink);
            else
                await Launcher.OpenAsync(Constants.FacebookWebUrl);
        });

        public ICommand OpenInstagramCommand => new Command(async (parameter) =>
        {
            var isDeepLinkingPossible = await Launcher.CanOpenAsync(Constants.InstagramDeepLink);
            if (isDeepLinkingPossible)
                await Launcher.OpenAsync(Constants.InstagramDeepLink);
            else
                await Launcher.OpenAsync(Constants.InstagramWebUrl);
        });

        public ICommand OpenGithubCommand => new Command(async (parameter) => await Launcher.OpenAsync(Constants.GithubUrl));

        public SocialNetworksPopupViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
