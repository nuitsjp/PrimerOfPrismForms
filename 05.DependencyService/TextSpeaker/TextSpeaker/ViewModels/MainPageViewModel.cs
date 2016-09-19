using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Services;
using TextSpeaker.Model;
using DependencyService = Xamarin.Forms.DependencyService;

namespace TextSpeaker.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public ICommand SpeachCommand { get; }
        //private readonly IDependencyService _dependencyService;
        private readonly ITextToSpeech _textToSpeech;
        //public MainPageViewModel(IDependencyService dependencyService)
        public MainPageViewModel(ITextToSpeech textToSpeech)
        {
            _textToSpeech = textToSpeech;
            SpeachCommand = new DelegateCommand(() =>
            {
                //DependencyService.Get<ITextToSpeech>().Speak(Title);
                //_dependencyService.Get<ITextToSpeech>().Speak(Title);
                _textToSpeech.Speak(Title);
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
