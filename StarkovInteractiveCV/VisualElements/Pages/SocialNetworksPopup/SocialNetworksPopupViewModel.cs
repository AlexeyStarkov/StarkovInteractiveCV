using System.Windows.Input;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.SocialNetworksPopup
{
    public class SocialNetworksPopupViewModel : ViewModelBase
    {
        private const string LinkedInDeepLink = "linkedin://alexeystarkov";
        private const string LinkedInWebUrl = "https://www.linkedin.com/in/alexeystarkov/";

        private const string GithubUrl = "https://github.com/AlexeyStarkov";

        private const string FacebookDeepLink = "fb://profile/100000224872882";
        private const string FacebookWebUrl = "https://www.facebook.com/AlexeyStarkov1991";

        private const string InstagramDeepLink = "instagram://user?username=phenman64";
        private const string InstagramWebUrl = "https://www.instagram.com/phenman64/";

        public ICommand OpenLinkedInCommand => new Command(async (parameter) =>
        {
            var isDeepLinkingPossible = await Launcher.CanOpenAsync(LinkedInDeepLink);
            if (isDeepLinkingPossible)
                await Launcher.OpenAsync(LinkedInDeepLink);
            else
                await Launcher.OpenAsync(LinkedInWebUrl);
        });

        public ICommand OpenFacebookCommand => new Command(async (parameter) =>
        {
            var isDeepLinkingPossible = await Launcher.CanOpenAsync(FacebookDeepLink);
            if (isDeepLinkingPossible)
                await Launcher.OpenAsync(FacebookDeepLink);
            else
                await Launcher.OpenAsync(FacebookWebUrl);
        });

        public ICommand OpenInstagramCommand => new Command(async (parameter) =>
        {
            var isDeepLinkingPossible = await Launcher.CanOpenAsync(InstagramDeepLink);
            if (isDeepLinkingPossible)
                await Launcher.OpenAsync(InstagramDeepLink);
            else
                await Launcher.OpenAsync(InstagramWebUrl);
        });

        public ICommand OpenGithubCommand => new Command(async (parameter) => await Launcher.OpenAsync(GithubUrl));

        public SocialNetworksPopupViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
