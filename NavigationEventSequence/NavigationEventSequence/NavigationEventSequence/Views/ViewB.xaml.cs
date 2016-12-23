using System.Diagnostics;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class ViewB : ContentPage
    {
        public ViewB()
        {
            Debug.WriteLine("ViewB#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("ViewB#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("ViewB#Disappearing");
        }
    }
}
