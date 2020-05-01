using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;

namespace StarkovInteractiveCV.VisualElements.BaseObjects
{
    public abstract class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        protected readonly INavigationService _navigationService;
        protected readonly IDialogService _dialogService;

        public ViewModelBase(INavigationService navigationService, IDialogService dialogService)
        {
            _dialogService = dialogService;
            _navigationService = navigationService;
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void Destroy()
        {
        }
    }
}
