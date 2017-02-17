using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace DeepLinks.ViewModels
{
    public class PageBViewModel : ViewModelBase
    {
        private INavigationService NavigationService { get; }
        public DelegateCommand NavigateCommand => new DelegateCommand(() => NavigationService.NavigateAsync("PageC"));
        public PageBViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }
    }
}
