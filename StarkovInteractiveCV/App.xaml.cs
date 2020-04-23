using Prism;
using Prism.Ioc;
using Prism.Unity;
using StarkovInteractiveCV.Interfaces;
using StarkovInteractiveCV.Services;
using StarkovInteractiveCV.VisualElements.Pages.MainPage;
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

            await NavigationService.NavigateAsync(nameof(MainPage));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();

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
