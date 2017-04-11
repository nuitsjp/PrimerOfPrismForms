using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public static class PageExtensions
    {
        public static void SetLogger(this Page page)
        {
            new PageEventLogger(page);
        }
    }
}
