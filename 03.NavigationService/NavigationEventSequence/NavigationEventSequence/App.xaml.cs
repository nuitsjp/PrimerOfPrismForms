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

            NavigationService.NavigateAsync("MyNavigationPage/ViewA");
            //NavigationService.NavigateAsync("MyNavigationPage/ViewA/ViewB");
            //NavigationService.NavigateAsync("MyTabbedPage/MyNavigationPage/ViewC");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<ViewA>();
            Container.RegisterTypeForNavigation<ViewB>();
            Container.RegisterTypeForNavigation<ViewC>();
            Container.RegisterTypeForNavigation<MyNavigationPage>();
        }
    }
}
