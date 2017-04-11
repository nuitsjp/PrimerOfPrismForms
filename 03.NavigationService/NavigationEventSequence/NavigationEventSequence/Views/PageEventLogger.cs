using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public class PageEventLogger
    {
        private readonly Page _page;
        public PageEventLogger(Page page)
        {
            _page = page;
            _page.Appearing += OnAppearing;
            _page.Disappearing += OnDisappearing;
        }

        private void OnDisappearing(object sender, EventArgs eventArgs)
        {
            WriteLog();
        }

        private void OnAppearing(object sender, EventArgs eventArgs)
        {
            WriteLog();
        }

        private void WriteLog([CallerMemberName] string callerMemberName = null)
        {
            Debug.WriteLine($"{_page.GetType().Name}#{callerMemberName}");
        }
    }
}
