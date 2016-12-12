using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;

namespace MasterDetailSample.ViewModels
{
    public class DetailA1PageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;
        public ICommand NavigationNextCommand { get; }
        public DetailA1PageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigationNextCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync("DetailA2Page");
            });
        }
    }
}
