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

            NavigationService.NavigateAsync(
                new Navigation(NavigateDestination.NavigationPage), 
                new Navigation(NavigateDestination.MainPage, "title=Hello%20from%20Xamarin.Forms"));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>(NavigateDestination.NavigationPage);
            Container.RegisterTypeForNavigation<MainPage>(NavigateDestination.MainPage);
            Container.RegisterTypeForNavigation<SecondPage>(NavigateDestination.SecondPage);
        }
    }
}
