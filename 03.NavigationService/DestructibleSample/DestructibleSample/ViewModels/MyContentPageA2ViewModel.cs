using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism.Navigation;

namespace DestructibleSample.ViewModels
{
    public class MyContentPageA2ViewModel : ViewModelBase
    {
        private INavigationService NavigationService { get; }
        public DelegateCommand NavigateToB2Command => new DelegateCommand(() =>
        {
            NavigationService.NavigateAsync(new Uri("file:///MyNavigationPageB/MyContentPageB1/MyContentPageB2"));
        });
        public MyContentPageA2ViewModel(INavigationService navigationService) : base("Page A2")
        {
            NavigationService = navigationService;
        }
    }
}
