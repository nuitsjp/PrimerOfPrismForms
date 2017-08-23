using Autofac;
using Prism.Autofac;
using Prism.Autofac.Forms;
using NaviTabbedNavigation.Views;
using Xamarin.Forms;

namespace NaviTabbedNavigation
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("RootPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MyNavigationPage>();
            Container.RegisterTypeForNavigation<ScheduleTabbedPage>();
            Container.RegisterTypeForNavigation<RootPage>();
            Container.RegisterTypeForNavigation<SchedulePage>();
            Container.RegisterTypeForNavigation<PrismContentPage>();
            Container.RegisterTypeForNavigation<TabPage2>();
        }
    }
}
