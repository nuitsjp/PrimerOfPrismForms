using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;

namespace ConfirmNavigationAsync.ViewModels
{
    public class NavigationWithHeavyProcessingPageViewModel : BindableBase, IConfirmNavigationAsync
    {
        private readonly INavigationService _navigationService;

        private bool _isProcessing;

        public bool IsProcessing
        {
            get { return _isProcessing; }
            set { SetProperty(ref _isProcessing, value); }
        }

        public DelegateCommand NavigateCommand => new DelegateCommand(() => _navigationService.NavigateAsync("CompletedNavigationPage"));
        public NavigationWithHeavyProcessingPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public async Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            IsProcessing = true;
            await ProcessHeavy();
            IsProcessing = false;
            return true;
        }

        private Task ProcessHeavy()
        {
            return Task.Delay(TimeSpan.FromSeconds(3));
        }
    }
}
