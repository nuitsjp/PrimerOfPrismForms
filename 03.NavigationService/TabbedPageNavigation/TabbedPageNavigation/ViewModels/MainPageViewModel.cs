using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace TabbedPageNavigation.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly INavigationService _navigationService;

        public ICommand GoToTabbedPageCommand { get; }
        public ICommand DeepLinkCommand { get; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GoToTabbedPageCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync("PrismTabbedPage");
            });

            DeepLinkCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync("PrismTabbedPage/NavigationPage/PrismContentPage1/PrismContentPage2");
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
