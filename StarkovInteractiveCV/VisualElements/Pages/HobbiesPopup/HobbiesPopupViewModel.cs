using System.Windows.Input;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.HobbiesPopup
{
    public class HobbiesPopupViewModel : ViewModelBase
    {
        public ICommand CloseCommand => new Command(async (parameter) => await _navigationService.GoBackAsync());

        public HobbiesPopupViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
