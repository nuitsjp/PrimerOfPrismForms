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
    public class ViewAViewModel : BindableBase, INavigationAware, IConfirmNavigation, IConfirmNavigationAsync, IDestructible
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand<string> NavigationCommand => new DelegateCommand<string>(page => _navigationService.NavigateAsync(page));

        public ViewAViewModel(INavigationService navigationService)
        {
            Debug.WriteLine("ViewAViewModel#Constructor()");
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewAViewModel#OnNavigatedFrom()");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewAViewModel#OnNavigatedTo()");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewAViewModel#OnNavigatingTo()");
        }

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewAViewModel#CanNavigateAsync()");
            return Task.FromResult(true);
        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewAViewModel#CanNavigate()");
            return true;
        }

        public void Destroy()
        {
            Debug.WriteLine("ViewAViewModel#Destroy()");
        }
    }
}
