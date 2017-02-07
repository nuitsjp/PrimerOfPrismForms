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

            NavigationService.NavigateAsync("MyNavigationPageA/MyContentPageA1/MyContentPageA2");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MyNavigationPageA>();
            Container.RegisterTypeForNavigation<MyNavigationPageB>();
            Container.RegisterTypeForNavigation<MyContentPageA1>();
            Container.RegisterTypeForNavigation<MyContentPageA2>();
            Container.RegisterTypeForNavigation<MyContentPageB1>();
            Container.RegisterTypeForNavigation<MyContentPageB2>();
        }
    }
}
