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
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigationOnPlatform<MainPage, MainPageViewModel>(
                iOSView: typeof(MainPage_iOS),
                otherView: typeof(MainPage));
        }
    }
}
