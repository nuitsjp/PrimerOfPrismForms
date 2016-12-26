using System.Diagnostics;
using NavigationEventSequence.ViewModels;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class MyTabNavigationPage : NavigationPage
    {
        private MyTabNavigationPageViewModel MyTabNavigationPageViewModel => BindingContext as MyTabNavigationPageViewModel;
        public MyTabNavigationPage()
        {
            Debug.WriteLine("MyTabNavigationPage#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) =>
            {
                Debug.WriteLine("MyTabNavigationPage#Appearing");
                MyTabNavigationPageViewModel.NavigationCommand.Execute("ViewC");
            };
            Disappearing += (sender, args) => Debug.WriteLine("MyTabNavigationPage#Disappearing");
        }
    }
}
