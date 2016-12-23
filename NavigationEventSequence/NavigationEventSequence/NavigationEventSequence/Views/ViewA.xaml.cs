using System.Diagnostics;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class ViewA : ContentPage
    {
        public ViewA()
        {
            Debug.WriteLine("ViewA#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("ViewA#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("ViewA#Disappearing");
        }
    }
}
