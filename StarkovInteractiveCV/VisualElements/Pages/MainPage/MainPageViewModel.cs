using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;
using Prism.Services.Dialogs;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.Models;
using StarkovInteractiveCV.VisualElements.BaseObjects;
using StarkovInteractiveCV.VisualElements.Pages.MainPage.UIModels;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.MainPage
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IThemeService _themeService;

        private IEnumerable<WorkExpirienceUIModel> _workExpirienceCollection;
        public IEnumerable<WorkExpirienceUIModel> WorkExpirienceCollection
        {
            get => _workExpirienceCollection;
            set => SetProperty(ref _workExpirienceCollection, value);
        }

        public ICommand OpenProfileCommand => new Command(async (parameter) => await _navigationService.NavigateAsync(nameof(ProfilePopup)));

        public ICommand OpenSocialNetworksCommand => new Command(async (parameter) => await _navigationService.NavigateAsync(nameof(SocialNetworksPopup)));

        public ICommand OpenHobbiesCommand => new Command(async (parameter) => await _navigationService.NavigateAsync(nameof(HobbiesPopup)));

        public ICommand OpenWorkflowExpirienceCommand => new Command(async (parameter) => await _navigationService.NavigateAsync(nameof(WorkflowExpiriencePopup)));

        public ICommand OpenDevSkillsCommand => new Command(async (parameter) => await _navigationService.NavigateAsync(nameof(DevSkillsPopup)));

        public ICommand OpenLanguagesCommand => new Command(async (parameter) => await _navigationService.NavigateAsync(nameof(LanguagesPopup)));

        public ICommand OpenContactMeCommand => new Command(async (parameter) => await _navigationService.NavigateAsync(nameof(ContactMePopup)));

        public ICommand OpenStrengthCommand => new Command(async (parameter) => await _navigationService.NavigateAsync(nameof(PersonalityPopup)));

        public ICommand OpenWorkDetailsCommand => new Command(async (parameter) => await _navigationService.NavigateAsync(nameof(WorkDetailsPage), new NavigationParameters() { { nameof(WorkExpirienceModel), ((WorkExpirienceUIModel)parameter).GetOriginalModel() } }));

        public ICommand SwitchThemeCommand => new Command((parameter) => _themeService.SwitchTheme());

        public MainPageViewModel(IExtendedNavigationService navigationService, IDialogService dialogService, IThemeService themeService)
            : base(navigationService, dialogService)
        {
            _themeService = themeService;
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            WorkExpirienceCollection = WorkExpirienceToUIModels(GetWorkExpiriences());

            base.OnNavigatedTo(parameters);
        }

        private IEnumerable<WorkExpirienceModel> GetWorkExpiriences()
        {
            return new List<WorkExpirienceModel>()
            {
                new WorkExpirienceModel(
                    new DateTime(2018, 11, 1), DateTime.Now,
                    "Task Retail Technology",
                    "Wrocław", "Poland",
                    new List<string>()
                    {
                        "More than 180 custom pages, animations and interactions for mobile apps implemented",
                        "Intercontinental multinational teamwork experience gained",
                        "Technical enhancements was implemented to reduce the labor required for each new application creation",
                        "Code quality increased"
                    },
                    new Dictionary<string, IEnumerable<string>>()
                    {
                        {
                            "Xamarin Developer", new List<string>()
                            {
                                "Cross-platform Mobile applications development and maintenence (both iOS and Android)",
                                "Custom UI/UX and business logic implementation"
                            }
                        },
                        {
                            ".NET Developer", new List<string>()
                            {
                                "Clean and scalable code writing for projects based on Xamarin, ASP.NET MVC WebAPI, Silverlight and WPF technologies"
                            }
                        }
                    }),
                new WorkExpirienceModel(
                    new DateTime(2017, 01, 1), new DateTime(2018, 11, 1),
                    "Self-Employed",
                    "Minsk", "Belarus",
                    new List<string>()
                    {
                        "All parts of self-service carwash control system was created from collecting desires of customer to an advanced multi-component control system. Thanks ultimate carwash software, the customer took the leading position on the market"
                    },
                    new Dictionary<string, IEnumerable<string>>()
                    {
                        {
                            "Xamarin Developer", new List<string>()
                            {
                                "Mobile application development (.NET C# Xamarin Forms)"
                            }
                        },
                        {
                            ".NET Developer", new List<string>()
                            {
                                "Windows desktop software development (.NET C# WPF)"
                            }
                        },
                        {
                            "Industrial PLC Software Developer", new List<string>()
                            {
                                "Industrial PLC software and HMI development (IEC 61131-3)"
                            }
                        },
                        {
                            "Solution provider", new List<string>()
                            {
                                "Analysis of a task, finding an optimal solution to satisfy business requirements",
                                "Development and detailing of application usage scenarios",
                                "Making estimations and negotiate with a customer",
                                "Requirements collecting",
                                "Specification writing",
                                "Guidance, instruction, supervision of a team"
                            }
                        },
                        {
                            "Architect", new List<string>()
                            {
                                "Development of principles and schemes for interaction of various components (equipment, operator's workplace, server, mobile application, bank payment system)",
                                "Hardware and communication protocols selection",
                                "Development of entities, relationships, user roles",
                            }
                        }
                    }),
                new WorkExpirienceModel(
                    new DateTime(2012, 09, 1), new DateTime(2017, 01, 1),
                    "Alvitex Group",
                    "Minsk", "Belarus",
                    new List<string>()
                    {
                        "Total turnover of the employer went up by 17% thanks reaching a new level of automated control systems quality"
                    },
                    new Dictionary<string, IEnumerable<string>>()
                    {
                        {
                            "Industrial PLC Software Developer",
                            new List<string>()
                            {
                                "Software development for industrial automation PLCs",
                                "Adjustment of an automated process control systems at plants",
                                "Development of electrical circuits and selection of PLC equipment for automation systems"
                            }
                        }
                    }),
            };
        }

        private IEnumerable<WorkExpirienceUIModel> WorkExpirienceToUIModels (IEnumerable<WorkExpirienceModel> workExpirienceModels)
            => workExpirienceModels?.Select(x => new WorkExpirienceUIModel(x));
    }
}
