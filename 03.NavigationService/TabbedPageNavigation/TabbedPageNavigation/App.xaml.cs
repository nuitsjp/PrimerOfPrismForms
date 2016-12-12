using Prism.Unity;
using TabbedPageNavigation.Views;
using Xamarin.Forms;

namespace TabbedPageNavigation
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<PrismTabbedPage>();
            Container.RegisterTypeForNavigation<PrismContentPage1>();
            Container.RegisterTypeForNavigation<PrismContentPage2>();
        }
    }
}
