using System;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.VisualElements.BaseObjects;

namespace StarkovInteractiveCV.VisualElements.Pages.WorkDetailsPage
{
    public class WorkDetailsViewModel : ViewModelBase
    {
        public WorkDetailsViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {


            base.OnNavigatedTo(parameters);
        }
    }
}
