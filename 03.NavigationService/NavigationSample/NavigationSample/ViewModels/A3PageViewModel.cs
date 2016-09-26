using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;

namespace NavigationSample.ViewModels
{
    public class A3PageViewModel : BindableBase, INavigationAware, IPushedAware, IPoppedAware, IAppearingAware, IDisappearingAware
    {
        public ICommand NavigateAbsoluteCommand { get; }
        public A3PageViewModel(INavigationService navigationService)
        {
            NavigateAbsoluteCommand = new DelegateCommand(() => navigationService.NavigateAsync("/MainPage"));
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public void OnPushed()
        {
        }

        public void OnPopped()
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
