using System.Collections.Generic;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.Models;
using StarkovInteractiveCV.VisualElements.BaseObjects;

namespace StarkovInteractiveCV.VisualElements.Pages.WorkDetailsPage
{
    public class WorkDetailsPageViewModel : ViewModelBase
    {
        private string _header;
        public string Header
        {
            get => _header;
            set => SetProperty(ref _header, value);
        }

        private string _subHeader;
        public string SubHeader
        {
            get => _subHeader;
            set => SetProperty(ref _subHeader, value);
        }

        private IDictionary<string, IEnumerable<string>> _rolesAndresponsibilities;
        public IDictionary<string, IEnumerable<string>> RolesAndresponsibilities
        {
            get => _rolesAndresponsibilities;
            set => SetProperty(ref _rolesAndresponsibilities, value);
        }

        private IEnumerable<string> _achivements;
        public IEnumerable<string> Achivements
        {
            get => _achivements;
            set => SetProperty(ref _achivements, value);
        }

        public WorkDetailsPageViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService, dialogService)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            var workExpirienceModel = parameters.GetValue<WorkExpirienceModel>(nameof(WorkExpirienceModel));
            if (workExpirienceModel != null)
            {
                Header = workExpirienceModel.WorkPeriodString.ToString();
                SubHeader = $"{workExpirienceModel.CompanyName}, {workExpirienceModel.WorkPlaceName}";
                RolesAndresponsibilities = workExpirienceModel.RolesAndresponsibilities;
                Achivements = workExpirienceModel.Achivements;
            }

            base.OnNavigatedTo(parameters);
        }
    }
}
