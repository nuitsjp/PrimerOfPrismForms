using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace MasterDetailSample.ViewModels
{
    public abstract class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
        private readonly INavigationService _navigationService;
        public ICommand NavigateCommand => new DelegateCommand<string>(page => _navigationService.NavigateAsync(page));
        public ICommand GoBackCommand => new DelegateCommand(() => _navigationService.GoBackAsync());
        protected ViewModelBase(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"{this.GetType().Name}#OnNavigatedFrom()");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{this.GetType().Name}#OnNavigatedTo()");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{this.GetType().Name}#OnNavigatingTo()");
        }

        public void Destroy()
        {
            Debug.WriteLine($"{this.GetType().Name}#Destroy()");
        }
    }
}
