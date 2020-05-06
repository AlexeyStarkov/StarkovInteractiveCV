using System;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.VisualElements.BaseObjects;

namespace StarkovInteractiveCV.VisualElements.Pages.PersonalityPopup
{
    public class PersonalityPopupViewModel : ViewModelBase
    {
        public PersonalityPopupViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
