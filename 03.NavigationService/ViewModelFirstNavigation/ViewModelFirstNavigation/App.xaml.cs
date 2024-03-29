﻿using Prism.Unity;
using ViewModelFirstNavigation.ViewModels;
using ViewModelFirstNavigation.Views;
using Xamarin.Forms;

namespace ViewModelFirstNavigation
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForViewModelNavigation<NextPage, NextPageViewModel>();
        }
    }
}
