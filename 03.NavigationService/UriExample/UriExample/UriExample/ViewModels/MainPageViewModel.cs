using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UriExample.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        private string _uriText = "/Navigation";
        private Uri _uri;
        private string _message;
        private string _uriToString;
        private readonly INavigationService _navigationService;

        public string UriText
        {
            get { return _uriText; }
            set { SetProperty(ref _uriText, value); }
        }

        public Uri Uri
        {
            get { return _uri; }
            set
            {
                if (SetProperty(ref _uri, value) && value != null)
                {
                    UriToString = value.ToString();
                }
            }
        }

        public string UriToString
        {
            get { return _uriToString; }
            set { SetProperty(ref _uriToString, value); }
        }

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public DelegateCommand GenerateUriCommand { get; }

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            GenerateUriCommand = new DelegateCommand(GenerateUri);

            _navigationService.NavigateAsync("");
        }

        private void GenerateUri()
        {
            try
            {
                Uri = new Uri(UriText, UriKind.RelativeOrAbsolute);
            }
            catch (Exception e)
            {
                Message = $"Message:{e.Message}\r\nStackTrace:\r\n{e.StackTrace}";
            }
        }

        public void NavigateAbsolute()
        {
            _navigationService.NavigateAsync("/NavigationPage/ContentPage");
        }


    }
}
