using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Navigation;

namespace DeepLinks.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        private static readonly ObservableCollection<string > _events = new ObservableCollection<string>();
        public ObservableCollection<string> Events => _events;
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            SaveEvent($"{GetType().Name}#OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            SaveEvent($"{GetType().Name}#OnNavigatedTo");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            SaveEvent($"{GetType().Name}#OnNavigatingTo");
        }

        private void SaveEvent(string eventMessage)
        {
            Debug.WriteLine(eventMessage);
            _events.Add(eventMessage);
        }
    }
}
