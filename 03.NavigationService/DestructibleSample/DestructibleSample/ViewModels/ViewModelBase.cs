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
    public class ViewModelBase : BindableBase, INavigationAware
    {
        private static readonly IDictionary<string, NavigationCounter> NavigationCounters = new Dictionary<string, NavigationCounter>();

        private string PageName { get; }

        private NavigationCounter Counter => NavigationCounters[PageName];

        public ViewModelBase(string pageName)
        {
            PageName = pageName;
            if (!NavigationCounters.ContainsKey(pageName))
            {
                NavigationCounters[pageName] = new NavigationCounter();
            }
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"{PageName}#OnNavigatedFrom.\tNumber of calls : {Counter.IncrementOnNavigatedFromCount()}");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{PageName}#OnNavigatedTo.\t\tNumber of calls : {Counter.IncrementOnNavigatedToCount()}");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{PageName}#OnNavigatingTo.\t\tNumber of calls : {Counter.IncrementOnNavigatingToCount()}");
        }

        public void Destroy()
        {
            Debug.WriteLine($"{PageName}#Destroy.\tNumber of calls : {Counter.IncrementDestroyCount()}");
        }

        public class NavigationCounter
        {
            private int OnNavigatedFromCount { get; set; }

            private int OnNavigatedToCount { get; set; }

            private int OnNavigatingToCount { get; set; }

            private int DestroyCount { get; set; }

            public int IncrementOnNavigatedFromCount() => ++OnNavigatedFromCount;

            public int IncrementOnNavigatedToCount() => ++OnNavigatedToCount;

            public int IncrementOnNavigatingToCount() => ++OnNavigatingToCount;

            public int IncrementDestroyCount() => ++DestroyCount;
        }
    }
}
