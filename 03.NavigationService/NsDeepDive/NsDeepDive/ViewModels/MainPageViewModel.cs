using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace NsDeepDive.ViewModels
{
    public class MainPageViewModel : BindableBase, IConfirmNavigation
    {
        private readonly INavigationService _navigationService;
        public bool CanNavigateSecond { get; set; }
        public ICommand NavigateSocondCommand { get; }
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateSocondCommand = new DelegateCommand(() =>
            {
                var navigationParameter = new NavigationParameters();
                navigationParameter["customer"] = new Customer();
                _navigationService.NavigateAsync("SecondPage", navigationParameter);
            });
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }
        public bool CanNavigate(NavigationParameters parameters)
        {
            return CanNavigateSecond;
        }
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }
    }
}
