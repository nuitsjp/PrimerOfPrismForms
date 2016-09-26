using System;
using Xamarin.Forms;

namespace NavigationSample.Views
{
    public partial class A3Page : ContentPage
    {
        public A3Page()
        {
            InitializeComponent();
        }
        private async void GoBackButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void GoBackToRootButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
