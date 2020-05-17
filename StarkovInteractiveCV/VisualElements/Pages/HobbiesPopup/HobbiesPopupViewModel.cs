using Prism.Services.Dialogs;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.VisualElements.BaseObjects;

namespace StarkovInteractiveCV.VisualElements.Pages.HobbiesPopup
{
    public class HobbiesPopupViewModel : ViewModelBase
    {
        public HobbiesPopupViewModel(IExtendedNavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
