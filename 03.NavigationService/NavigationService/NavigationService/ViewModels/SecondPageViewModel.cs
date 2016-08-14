using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;

namespace NavigationService.ViewModels
{
    public class SecondPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public ICommand GoBackCommand { get; }
        public SecondPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new DelegateCommand(() =>
            {
                _navigationService.GoBackAsync();
            });
        }
    }
}
