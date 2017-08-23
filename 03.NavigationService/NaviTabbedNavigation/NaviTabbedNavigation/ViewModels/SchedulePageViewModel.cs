using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism;
using Prism.Navigation;

namespace NaviTabbedNavigation.ViewModels
{
    public class SchedulePageViewModel : BindableBase, INavigationAware, IActiveAware
    {
        private bool _isActive;

        private readonly INavigationService _navigationService;

        public DelegateCommand PushCommand => new DelegateCommand(() =>
        {
            _navigationService.NavigateAsync("PrismContentPage", useModalNavigation:false);
        });

        public SchedulePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"{GetType().Name}:OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{GetType().Name}:OnNavigatedTo");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{GetType().Name}:OnNavigatingTo");
        }

        public bool IsActive
        {
            get => _isActive;
            set
            {
                Debug.WriteLine($"{GetType().Name}:IsActive value:{value}");
                _isActive = value;
            }
        }

        public event EventHandler IsActiveChanged;
    }
}
