using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace ViewModelFirstNavigation.ViewModels
{
    public class NextPageViewModel : BindableBase, INavigationAware
    {
        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public NextPageViewModel()
        {

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("Message"))
            {
                Message = (string)parameters["Message"];
            }
        }
    }
}
