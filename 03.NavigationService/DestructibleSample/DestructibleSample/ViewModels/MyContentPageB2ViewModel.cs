using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace DestructibleSample.ViewModels
{
    public class MyContentPageB2ViewModel : BindableBase
    {
        private INavigationService NavigationService { get; }
        public DelegateCommand NavigateToA2Command => new DelegateCommand(() =>
        {
            NavigationService.NavigateAsync(new Uri("file:///MyNavigationPageA/MyContentPageA1/MyContentPageA2"));
        });
        public MyContentPageB2ViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
