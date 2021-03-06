﻿using Prism;
using Prism.Ioc;
using Prism.Plugin.Popups;
using Prism.Unity;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.Services;
using StarkovInteractiveCV.VisualElements.Pages.ContactMePopup;
using StarkovInteractiveCV.VisualElements.Pages.DevSkillsPopup;
using StarkovInteractiveCV.VisualElements.Pages.HobbiesPopup;
using StarkovInteractiveCV.VisualElements.Pages.LanguagesPopup;
using StarkovInteractiveCV.VisualElements.Pages.MainPage;
using StarkovInteractiveCV.VisualElements.Pages.PersonalityPopup;
using StarkovInteractiveCV.VisualElements.Pages.ProfilePopup;
using StarkovInteractiveCV.VisualElements.Pages.SocialNetworksPopup;
using StarkovInteractiveCV.VisualElements.Pages.WorkDetailsPage;
using StarkovInteractiveCV.VisualElements.Pages.WorkflowExpiriencePopup;
using Xamarin.Forms;

namespace StarkovInteractiveCV
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.Android)
            {
                var themeService = Container.Resolve<IThemeService>();
                themeService.SetThemeResources(themeService.CurrentTheme);
            }
            
            await NavigationService.NavigateAsync($"NavigationPage/{nameof(MainPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterPopupNavigationService();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<HobbiesPopup, HobbiesPopupViewModel>();
            containerRegistry.RegisterForNavigation<SocialNetworksPopup, SocialNetworksPopupViewModel>();
            containerRegistry.RegisterForNavigation<WorkflowExpiriencePopup, WorkflowExpiriencePopupViewModel>();
            containerRegistry.RegisterForNavigation<DevSkillsPopup, DevSkillsPopupViewModel>();
            containerRegistry.RegisterForNavigation<LanguagesPopup, LanguagesPopupViewModel>();
            containerRegistry.RegisterForNavigation<ContactMePopup, ContactMePopupViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePopup, ProfilePopupViewModel>();
            containerRegistry.RegisterForNavigation<PersonalityPopup, PersonalityPopupViewModel>();
            containerRegistry.RegisterForNavigation<WorkDetailsPage, WorkDetailsPageViewModel>();

            containerRegistry.RegisterSingleton<IExtendedNavigationService, ExtendedNavigationService>();
            containerRegistry.RegisterSingleton<ISettingsService, SettingsService>();
            containerRegistry.RegisterSingleton<IThemeService, ThemeService>();
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}
