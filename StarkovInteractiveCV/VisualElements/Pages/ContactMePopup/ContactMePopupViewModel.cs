using System.Windows.Input;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.ContactMePopup
{
    public class ContactMePopupViewModel : ViewModelBase
    {
        private const string PhoneNumberLink = "tel:+48796304653";
        private const string EmailAddressLink = "mailto:alexey.starkov@protonmail.com";

        public ICommand CallMeCommand => new Command(async (parameter) => await Launcher.OpenAsync(PhoneNumberLink));
        public ICommand EmailMeCommand => new Command(async (parameter) => await Launcher.OpenAsync(EmailAddressLink));

        public ContactMePopupViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
