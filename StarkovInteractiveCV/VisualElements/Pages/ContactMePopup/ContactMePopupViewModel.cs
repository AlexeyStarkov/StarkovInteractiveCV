using System.Windows.Input;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.Helpers;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.ContactMePopup
{
    public class ContactMePopupViewModel : ViewModelBase
    {
        public ICommand CallMeCommand => new Command(async (parameter) => await Launcher.OpenAsync(Constants.PhoneNumberDeepLink));
        public ICommand EmailMeCommand => new Command(async (parameter) => await Launcher.OpenAsync(Constants.EmailAddressDeepLink));

        public ContactMePopupViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
