using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace NavigationSample.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ICommand NavigateNavigationPageCommand { get; }
        public ICommand NavigateToNextPageCommand { get; }

        public MainPageViewModel(INavigationService navigationService)
        {
            NavigateNavigationPageCommand = new DelegateCommand(() => navigationService.NavigateAsync("NotifyNavigationPage/A1Page"));
            NavigateToNextPageCommand = new DelegateCommand(() => navigationService.NavigateAsync("A1Page"));
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
