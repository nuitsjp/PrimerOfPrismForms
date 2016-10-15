using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Services;

namespace ConfirmNavigationAsync.ViewModels
{
    public class MainPageViewModel : BindableBase, IConfirmNavigationAsync
    {
        private bool _isRunning;

        public bool IsRunning
        {
            get { return _isRunning; }
            set { SetProperty(ref _isRunning, value); }
        }
        public bool IsConfirm { get; set; }
        public bool IsHeavy { get; set; }

        public DelegateCommand<string> NavigationCommand => new DelegateCommand<string>((pageName) => _navigationService.NavigateAsync(pageName));

        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;
        public MainPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
        }

        public async Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            if (IsConfirm)
            {
                return await _pageDialogService.DisplayAlertAsync("title", "message", "ok", "cancel");
            }
            else if (IsHeavy)
            {
                IsRunning = true;
                await Task.Delay(TimeSpan.FromSeconds(5));
                IsRunning = false;
                return await Task.FromResult(true);
            }
            else
            {
                return await Task.FromResult(true);
            }
        }
    }
}
