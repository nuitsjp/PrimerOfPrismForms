using System.Diagnostics;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class MyTabbedPage : TabbedPage
    {
        public MyTabbedPage()
        {
            Debug.WriteLine("MyTabbedPage#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("MyTabbedPage#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("MyTabbedPage#Disappearing");
        }
    }
}
