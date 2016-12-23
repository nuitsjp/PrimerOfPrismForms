using System.Diagnostics;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class ViewC : ContentPage
    {
        public ViewC()
        {
            Debug.WriteLine("ViewC#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("ViewC#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("ViewC#Disappearing");
        }
    }
}
