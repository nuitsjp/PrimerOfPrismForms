using System.Linq.Expressions;
using Prism.Navigation;
using Prism.Unity;
using TypeSafeNavigation.ViewModels;
using TypeSafeNavigation.Views;
using Xamarin.Forms;

namespace TypeSafeNavigation
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            var navigation = new Navigation(NavigateDestination.MainPage);
            navigation["title"] = "Hello from Xamarin.Forms";
            NavigationService.NavigateAsync(new Navigation(NavigateDestination.NavigationPage), navigation);
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>(NavigateDestination.NavigationPage);
            Container.RegisterTypeForNavigation<MainPage>(NavigateDestination.MainPage);
            Container.RegisterTypeForNavigation<SecondPage>(NavigateDestination.SecondPage);
        }
    }
}
