using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;

namespace DestructibleSample.ViewModels
{
    public class MyContentPageA1ViewModel : BindableBase, INavigationAware, IDestructible
    {
        private INavigationService NavigationService { get; }
        public DelegateCommand NavigateToPageA2Command => new DelegateCommand(() => NavigationService.NavigateAsync("MyContentPageA2"));

        public MyContentPageA1ViewModel(INavigationService navigationService)
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
