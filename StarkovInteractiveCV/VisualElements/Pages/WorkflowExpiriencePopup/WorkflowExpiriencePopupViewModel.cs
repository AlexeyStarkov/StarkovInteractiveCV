using System;
using System.Windows.Input;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.WorkflowExpiriencePopup
{
    public class WorkflowExpiriencePopupViewModel : ViewModelBase
    {
        public ICommand CloseCommand => new Command(async (parameter) =>
        {
            await _navigationService.GoBackAsync();
        });

        public WorkflowExpiriencePopupViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }
    }
}
