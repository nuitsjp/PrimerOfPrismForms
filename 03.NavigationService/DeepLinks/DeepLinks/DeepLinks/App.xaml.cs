using Prism.Unity;
using DeepLinks.Views;
using Xamarin.Forms;

namespace DeepLinks
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("PageA/PageB/PageC");
            //NavigationService.NavigateAsync("PageA");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MyNavigationPage>();
            Container.RegisterTypeForNavigation<PageA>();
            Container.RegisterTypeForNavigation<PageB>();
            Container.RegisterTypeForNavigation<PageC>();
        }
    }
}
