using System.Diagnostics;
using System.Threading.Tasks;
using Prism.Navigation;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class ViewA : ContentPage, INavigationAware, IConfirmNavigation, IConfirmNavigationAsync, IDestructible
    {
        public ViewA()
        {
            Debug.WriteLine("ViewA#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("ViewA#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("ViewA#Disappearing");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewA#OnNavigatedFrom()");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewA#OnNavigatedTo()");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewA#OnNavigatingTo()");
        }

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewA#CanNavigateAsync()");
            return Task.FromResult(true);
        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            Debug.WriteLine("ViewA#CanNavigate()");
            return true;
        }

        public void Destroy()
        {
            Debug.WriteLine("ViewA#Destroy()");
        }

    }
}
