using System.Diagnostics;
using Prism.Navigation;
using Xamarin.Forms;

namespace DestructibleSample.Views
{
    public partial class MyContentPageA3 : ContentPage, INavigationAware, IDestructible
    {
        public MyContentPageA3()
        {
            InitializeComponent();
        }
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"{GetType().Name}#OnNavigatedFrom");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{GetType().Name}#OnNavigatedTo");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"{GetType().Name}#OnNavigatingTo");
        }

        public void Destroy()
        {
            Debug.WriteLine($"{GetType().Name}#Destroy");
        }

    }
}
