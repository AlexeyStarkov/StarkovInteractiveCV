using System.Windows.Input;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.LanguagesPopup
{
    public class LanguagesPopupViewModel : ViewModelBase
    {
        public ICommand CloseCommand => new Command(async (parameter) =>
        {
            await _navigationService.GoBackAsync();
        });

        public LanguagesPopupViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
