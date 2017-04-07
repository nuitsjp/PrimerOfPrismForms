using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PageDialogBehavior.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _title = "Hello from Xamarin.Forms";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public DelegateCommand UpdateTitleCommand => new DelegateCommand(() =>
        {
            Title = "Updated Title.";
        });
    }
}
