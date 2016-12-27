using System.Diagnostics;
using System.Threading.Tasks;
using Prism.Navigation;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class ViewB : ContentPage, INavigationAware, IConfirmNavigation, IConfirmNavigationAsync, IDestructible
    {
        public ViewB()
        {
            Debug.WriteLine("ViewB#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("ViewB#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("ViewB#Disappearing");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewB#OnNavigatedFrom()");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewB#OnNavigatedTo()");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewB#OnNavigatingTo()");
        }

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewB#CanNavigateAsync()");
            return Task.FromResult(true);
        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewB#CanNavigate()");
            return true;
        }

        public void Destroy()
        {
            Debug.WriteLine("ViewB#Destroy()");
        }

    }
}
