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

            NavigationService.NavigateAsync("MainPage", useModalNavigation:true);
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<DetailA1Page>();
            Container.RegisterTypeForNavigation<DetailA2Page>();
        }
    }
}
