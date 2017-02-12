using Prism.Unity;
using DestructibleSample.Views;

namespace DestructibleSample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage/MyNavigationPage/MyContentPageA1/MyContentPageA2");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<MyNavigationPage>();
            Container.RegisterTypeForNavigation<MyContentPageA1>();
            Container.RegisterTypeForNavigation<MyContentPageA2>();
            Container.RegisterTypeForNavigation<MyContentPageA3>();
        }
    }
}
