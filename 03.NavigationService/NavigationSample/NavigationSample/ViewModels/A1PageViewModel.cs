using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;

namespace NavigationSample.ViewModels
{
    public class A1PageViewModel : BindableBase, INavigationAware, IPoppedToRootAware, IAppearingAware, IDisappearingAware
    {
        public ICommand GoNextCommand { get; }
        public ICommand GoBackCommand { get; }
        public A1PageViewModel(INavigationService navigationService)
        {
            GoNextCommand = new DelegateCommand(() => navigationService.NavigateAsync("A2Page"));
            GoBackCommand = new DelegateCommand(() => navigationService.GoBackAsync());
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnPoppedToRoot()
        {
        }

        public void OnAppearing()
        {
        }

        public void OnDisappearing()
        {
        }
    }
}
