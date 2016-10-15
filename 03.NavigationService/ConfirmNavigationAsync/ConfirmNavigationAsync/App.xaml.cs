using Prism.Unity;
using ConfirmNavigationAsync.Views;
using Xamarin.Forms;

namespace ConfirmNavigationAsync
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<ConfirmNavigationPage>();
            Container.RegisterTypeForNavigation<NavigationWithHeavyProcessingPage>();
            Container.RegisterTypeForNavigation<CompletedNavigationPage>();
        }
    }
}
