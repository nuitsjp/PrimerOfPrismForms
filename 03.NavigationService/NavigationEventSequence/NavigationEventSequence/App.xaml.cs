using Prism.Unity;
using NavigationEventSequence.Views;
using Xamarin.Forms;

namespace NavigationEventSequence
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MenuPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MenuPage>();
            Container.RegisterTypeForNavigation<PrismMasterDetailPage>();
            Container.RegisterTypeForNavigation<PrismNavigationPageA>();
            Container.RegisterTypeForNavigation<PrismContentPageA1>();
            Container.RegisterTypeForNavigation<PrismNavigationPageB>();
            Container.RegisterTypeForNavigation<PrismContentPageB1>();
            Container.RegisterTypeForNavigation<PrismContentPageA2>();
            Container.RegisterTypeForNavigation<PrismTabbedPage>();
            Container.RegisterTypeForNavigation<PrismContentPageB2>();
            Container.RegisterTypeForNavigation<PrismContentPageB3>();
            Container.RegisterTypeForNavigation<PrismContentPageA3>();
        }
    }
}
