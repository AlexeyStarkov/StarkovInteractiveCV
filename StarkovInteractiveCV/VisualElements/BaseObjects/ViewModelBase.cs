using System.Windows.Input;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.Interfaces;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.BaseObjects
{
    public abstract class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        protected readonly IExtendedNavigationService _navigationService;
        protected readonly IDialogService _dialogService;

        public virtual ICommand GoBackCommand => new Command(async (parameter) => await _navigationService.GoBackAsync());

        public ViewModelBase(IExtendedNavigationService navigationService, IDialogService dialogService)
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
