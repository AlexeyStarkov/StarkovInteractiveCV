using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.UIModels;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.MainPage
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IThemeService _themeService;

        private IEnumerable<WorkExpirienceModel> _workExpirienceCollection;
        public IEnumerable<WorkExpirienceModel> WorkExpirienceCollection
        {
            get => _workExpirienceCollection;
            set => SetProperty(ref _workExpirienceCollection, value);
        }

        public ICommand OpenProfileCommand => new Command(async (parameter) =>
        {

        });

        public ICommand SwitchThemeCommand => new Command((parameter) => _themeService.SwitchTheme());

        public MainPageViewModel(INavigationService navigationService, IThemeService themeService)
            : base(navigationService)
         {
            _themeService = themeService;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            WorkExpirienceCollection = GetWorkExpiriences();

            base.OnNavigatedTo(parameters);
        }

        private IEnumerable<WorkExpirienceModel> GetWorkExpiriences()
        {
            return new List<WorkExpirienceModel>()
            {
                new WorkExpirienceModel(
                    new DateTime(2018, 11, 1), DateTime.Now,
                    "Task Retail Technology",
                    "Xamarin .NET Software Developer",
                    "Wrocław", "Poland"
                    ),
                new WorkExpirienceModel(
                    new DateTime(2017, 01, 1), new DateTime(2018, 11, 1),
                    "Self-Employed",
                    ".NET Software Developer",
                    "Minsk", "Belarus"
                    ),
                new WorkExpirienceModel(
                    new DateTime(2012, 09, 1), new DateTime(2017, 01, 1),
                    "Alvitex Group",
                    "Industrial Automation Software Developer",
                    "Minsk", "Belarus"
                    ),
            };
        }
    }
}
