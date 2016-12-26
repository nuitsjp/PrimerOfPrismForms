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
    public class MyTabbedPageViewModel : BindableBase, INavigationAware, IConfirmNavigation, IConfirmNavigationAsync, IDestructible
    {
        public MyTabbedPageViewModel()
        {
            Debug.WriteLine("MyTabbedPageViewModel#Constructor()");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabbedPageViewModel#OnNavigatedFrom()");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabbedPageViewModel#OnNavigatedTo()");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabbedPageViewModel#OnNavigatingTo()");
        }

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabbedPageViewModel#CanNavigateAsync()");
            return Task.FromResult(true);
        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            Debug.WriteLine("MyTabbedPageViewModel#CanNavigate()");
            return true;
        }

        public void Destroy()
        {
            Debug.WriteLine("MyNavigationPageViewModel#Destroy()");
        }
    }
}
