using Prism.Services.Dialogs;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.VisualElements.BaseObjects;

namespace StarkovInteractiveCV.VisualElements.Pages.PersonalityPopup
{
    public class PersonalityPopupViewModel : ViewModelBase
    {
        public PersonalityPopupViewModel(IExtendedNavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
