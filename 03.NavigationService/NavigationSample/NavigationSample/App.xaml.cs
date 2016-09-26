using Prism.Unity;
using NavigationSample.Views;

namespace NavigationSample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MyNavigationPage>();
            Container.RegisterTypeForNavigation<A1Page>();
            Container.RegisterTypeForNavigation<A2Page>();
            Container.RegisterTypeForNavigation<A3Page>();
        }
    }
}
