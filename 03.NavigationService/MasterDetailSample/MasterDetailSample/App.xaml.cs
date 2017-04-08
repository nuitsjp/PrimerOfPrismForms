using Prism.Unity;
using MasterDetailSample.Views;
using Xamarin.Forms;

namespace MasterDetailSample
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage/NavigationPage/DetailPageA");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<DetailPageA>();
            Container.RegisterTypeForNavigation<DetailPageB>();
            Container.RegisterTypeForNavigation<DetailPageC>();
        }
    }
}
