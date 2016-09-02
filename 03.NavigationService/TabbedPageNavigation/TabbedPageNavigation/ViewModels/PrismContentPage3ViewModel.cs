using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;

namespace TabbedPageNavigation.ViewModels
{
    public class PrismContentPage3ViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public ICommand GoBackCommand { get; }
        public PrismContentPage3ViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoBackCommand = new DelegateCommand(() =>
            {
                _navigationService.GoBackAsync();
            });
        }
    }
}
