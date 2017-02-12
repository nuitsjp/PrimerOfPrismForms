using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace DestructibleSample.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IDestructible
    {
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
