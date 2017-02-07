using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace DestructibleWithAbsoluteNavigate.ViewModels
{
    public class MyContentPageA2ViewModel : BindableBase
    {
        private INavigationService NavigationService { get; }
        public DelegateCommand NavigateB2Command => new DelegateCommand(() => NavigationService.NavigateAsync(new Uri("file:///MyNavigationPageB/MyContentPageB1/MyContentPageB2")));
        public MyContentPageA2ViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
