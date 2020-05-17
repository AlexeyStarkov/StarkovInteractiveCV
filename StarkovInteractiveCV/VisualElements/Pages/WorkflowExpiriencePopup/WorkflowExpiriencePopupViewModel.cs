using Prism.Services.Dialogs;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.VisualElements.BaseObjects;

namespace StarkovInteractiveCV.VisualElements.Pages.WorkflowExpiriencePopup
{
    public class WorkflowExpiriencePopupViewModel : ViewModelBase
    {
        public WorkflowExpiriencePopupViewModel(IExtendedNavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
