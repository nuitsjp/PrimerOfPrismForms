using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;

namespace TabbedPageNavigation.ViewModels
{
    public class PrismContentPage1ViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public ICommand GoNextCommand { get; }
        public PrismContentPage1ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoNextCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync("PrismContentPage2");
            });
        }
    }
}
