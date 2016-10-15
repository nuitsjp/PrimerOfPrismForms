using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace PrismDemoApp.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _text;
        private bool _isActive;

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value); }
        }

        public DelegateCommand UpdateTextCommand => 
            new DelegateCommand(UpdateText).ObservesCanExecute(_ => IsActive);

        private void UpdateText()
        {
            Text = "Updated";
            _navigationService.NavigateAsync("ViewA");
        }

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
            if (parameters.ContainsKey("text"))
                Text = (string) parameters["text"];
        }

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            return _pageDialogService.DisplayAlertAsync("title", "message", "ok", "cancel");
        }
    }
}
