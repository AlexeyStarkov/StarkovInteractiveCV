using Prism.Services.Dialogs;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.VisualElements.BaseObjects;

namespace StarkovInteractiveCV.VisualElements.Pages.LanguagesPopup
{
    public class LanguagesPopupViewModel : ViewModelBase
    {
        public LanguagesPopupViewModel(IExtendedNavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
