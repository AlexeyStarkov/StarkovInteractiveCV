using Prism;
using Prism.Ioc;
using Prism.Unity;
using StarkovInteractiveCV.VisualElements.Pages.MainPage;

namespace StarkovInteractiveCV
{
    public partial class App : PrismApplication
    {
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync(nameof(MainPage));
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();   
        }
    }
}
