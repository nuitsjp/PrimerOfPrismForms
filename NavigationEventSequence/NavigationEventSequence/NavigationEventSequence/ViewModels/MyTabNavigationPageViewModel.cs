using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;

namespace NavigationEventSequence.ViewModels
{
    public class MyTabNavigationPageViewModel : BindableBase, INavigationAware, IConfirmNavigation, IConfirmNavigationAsync, IDestructible
    {
        private readonly INavigationService _navigationService;


        public DelegateCommand<string> NavigationCommand => new DelegateCommand<string>(page => _navigationService.NavigateAsync(page));

        public MyTabNavigationPageViewModel(INavigationService navigationService)
        {
            Debug.WriteLine("MyTabNavigationPageViewModel#Constructor()");
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabNavigationPageViewModel#OnNavigatedFrom()");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabNavigationPageViewModel#OnNavigatedTo()");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabNavigationPageViewModel#OnNavigatingTo()");
        }

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabNavigationPageViewModel#CanNavigateAsync()");
            return Task.FromResult(true);
        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabNavigationPageViewModel#CanNavigate()");
            return true;
        }

        public void Destroy()
        {
            Debug.WriteLine("MyTabNavigationPageViewModel#Destroy()");
        }

    }
}
