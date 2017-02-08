using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;

namespace DestructibleSample.ViewModels
{
    public class MyContentPageA1ViewModel : ViewModelBase
    {
        private INavigationService NavigationService { get; }
        public DelegateCommand NavigateToPageA2Command => new DelegateCommand(() => NavigationService.NavigateAsync("MyContentPageA2"));

        public MyContentPageA1ViewModel(INavigationService navigationService) : base("Page A1")
        {
            NavigationService = navigationService;
        }
    }
}
