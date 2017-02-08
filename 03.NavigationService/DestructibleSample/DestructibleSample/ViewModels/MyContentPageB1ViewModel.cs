using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Prism.Navigation;

namespace DestructibleSample.ViewModels
{
    public class MyContentPageB1ViewModel : BindableBase, INavigatedAware, IDestructible
    {
        private INavigationService NavigationService { get; }

        public DelegateCommand NavigateToPageB2Command => new DelegateCommand(() => NavigationService.NavigateAsync("MyContentPageB2"));
        public MyContentPageB1ViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"{GetType().Name}#OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{GetType().Name}#OnNavigatedTo");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{GetType().Name}#OnNavigatingTo");
        }

        public void Destroy()
        {
            Debug.WriteLine($"{GetType().Name}#Destroy");
        }

    }
}
