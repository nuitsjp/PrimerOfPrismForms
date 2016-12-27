using System.Diagnostics;
using System.Threading.Tasks;
using Prism.Navigation;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class MyNavigationPage : NavigationPage, INavigationAware, IConfirmNavigation, IConfirmNavigationAsync, IDestructible
    {
        public MyNavigationPage()
        {
            Debug.WriteLine("MyNavigationPage#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("MyNavigationPage#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("MyNavigationPage#Disappearing");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine("MyNavigationPage#OnNavigatedFrom()");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine("MyNavigationPage#OnNavigatedTo()");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine("MyNavigationPage#OnNavigatingTo()");
        }

        public Task<bool> CanNavigateAsync(NavigationParameters parameters)
        {
            Debug.WriteLine("MyNavigationPage#CanNavigateAsync()");
            return Task.FromResult(true);
        }

        public bool CanNavigate(NavigationParameters parameters)
        {
            Debug.WriteLine("MyNavigationPage#CanNavigate()");
            return true;
        }

        public void Destroy()
        {
            Debug.WriteLine("MyNavigationPage#Destroy()");
        }
    }
}
