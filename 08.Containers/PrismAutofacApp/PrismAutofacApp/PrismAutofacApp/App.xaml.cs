using Autofac;
using Prism.Autofac;
using Prism.Autofac.Forms;
using PrismAutofacApp.ViewModels;
using PrismAutofacApp.Views;

namespace PrismAutofacApp
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
            var builder = new ContainerBuilder();
            builder.RegisterType<MainPageViewModel>();
            builder.Update(Container);

            Container.RegisterTypeForNavigation<MainPage>();
        }
    }
}
