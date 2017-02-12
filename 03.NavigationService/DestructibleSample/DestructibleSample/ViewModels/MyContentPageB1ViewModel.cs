using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism.Navigation;

namespace DestructibleSample.ViewModels
{
    public class MyContentPageB1ViewModel : ViewModelBase
    {
        private INavigationService NavigationService { get; }

        public DelegateCommand NavigateToPageB2Command => new DelegateCommand(() => NavigationService.NavigateAsync("MyContentPageB2"));
        public MyContentPageB1ViewModel(INavigationService navigationService) : base("Page B1")
        {
            NavigationService = navigationService;
        }
    }
}
