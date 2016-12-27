using System.Diagnostics;
using System.Threading.Tasks;
using Prism.Navigation;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class ViewC : ContentPage, INavigationAware, IConfirmNavigation, IConfirmNavigationAsync, IDestructible
    {
        public ViewC()
        {
            Debug.WriteLine("ViewC#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("ViewC#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("ViewC#Disappearing");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewC#OnNavigatedFrom()");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewC#OnNavigatedTo()");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewC#OnNavigatingTo()");
        }

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewC#CanNavigateAsync()");
            return Task.FromResult(true);
        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewC#CanNavigate()");
            return true;
        }

        public void Destroy()
        {
            Debug.WriteLine("ViewC#Destroy()");
        }

    }
}
