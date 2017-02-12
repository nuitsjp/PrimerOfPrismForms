using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace DestructibleSample.ViewModels
{
    public class MyContentPageA3ViewModel : ViewModelBase
    {
        private INavigationService NavigationService { get; }
        public DelegateCommand NaivgateAbstructeCommand => new DelegateCommand(() => NavigationService.NavigateAsync("/MainPage/MyNavigationPage/MyContentPageA1/MyContentPageA2"));
        public MyContentPageA3ViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
