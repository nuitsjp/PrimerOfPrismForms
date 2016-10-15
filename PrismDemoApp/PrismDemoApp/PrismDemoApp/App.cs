using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism.Navigation;
using Prism.Unity;
using PrismDemoApp.Views;
using Xamarin.Forms;

namespace PrismDemoApp
{
    public class App : PrismApplication
    {
        protected override void OnInitialized()
        {
            var param = new NavigationParameters();
            param.Add("text", "Hello form prism");
            NavigationService.NavigateAsync("NavigationPage/MainPage/ViewA", param);
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<ViewA>();
            Container.RegisterTypeForNavigation<ViewB>();
        }
    }
}
