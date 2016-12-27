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
    public class ViewBViewModel : BindableBase, INavigationAware, IConfirmNavigation, IConfirmNavigationAsync, IDestructible
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand<string> NavigationCommand => new DelegateCommand<string>(page => _navigationService.NavigateAsync(page));
        public DelegateCommand<string> GoBackCommand => new DelegateCommand<string>(page => _navigationService.GoBackAsync());

        public ViewBViewModel(INavigationService navigationService)
        {
            Debug.WriteLine("ViewBViewModel#Constructor()");
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewBViewModel#OnNavigatedFrom()");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewBViewModel#OnNavigatedTo()");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewBViewModel#OnNavigatingTo()");
        }

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewBViewModel#CanNavigateAsync()");
            return Task.FromResult(true);
        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewBViewModel#CanNavigate()");
            return true;
        }

        public void Destroy()
        {
            Debug.WriteLine("ViewBViewModel#Destroy()");
        }
    }
}
