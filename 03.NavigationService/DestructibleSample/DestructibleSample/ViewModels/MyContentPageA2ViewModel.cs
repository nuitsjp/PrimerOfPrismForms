using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace DestructibleSample.ViewModels
{
    public class MyContentPageA2ViewModel : ViewModelBase
    {
        private INavigationService NavigationService { get; }
        public DelegateCommand MyContentPageA3Command => new DelegateCommand(() => NavigationService.NavigateAsync("MyContentPageA3", useModalNavigation:true));
        public MyContentPageA2ViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
