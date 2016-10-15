using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;
using Prism.Services;

namespace ConfirmNavigationAsync.ViewModels
{
    public class ConfirmNavigationPageViewModel : BindableBase, IConfirmNavigationAsync
    {
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;
        public DelegateCommand NavigateCommand => new DelegateCommand(() => _navigationService.NavigateAsync("CompletedNavigationPage"));
        public ConfirmNavigationPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
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

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            return _pageDialogService.DisplayAlertAsync("title", "confirm message", "OK", "Cancel");
        }
    }
}
