using OnPlatformViewSample.ViewModels;
using Prism.Unity;
using OnPlatformViewSample.Views;

namespace OnPlatformViewSample
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
            Container.RegisterTypeForNavigationOnPlatform<MainPage_iOS, MainPageViewModel>(
                "MainPage",
                iOSView: typeof(MainPage_iOS),
                androidView: typeof(MainPage_Android),
                windowsView: typeof(MainPage_UWP));
            //Container.RegisterTypeForNavigationOnIdiom<MainPagePhone, MainPageViewModel>(
            //    "MainPage",
            //    phoneView: typeof(MainPagePhone),
            //    tabletView: typeof(MainPageTablet),
            //    desktopView: typeof(MainPageDesktop));
        }
    }
}
