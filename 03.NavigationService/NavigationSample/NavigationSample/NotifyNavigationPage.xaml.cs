using Xamarin.Forms;

namespace NavigationSample
{
    public partial class NotifyNavigationPage : NavigationPage
    {
        public NotifyNavigationPage()
        {
            InitializeComponent();
        }

        private void OnPushed(object sender, NavigationEventArgs e)
        {
            (e.Page.BindingContext as IPushedAware)?.OnPushed();
        }

        private void OnPopped(object sender, NavigationEventArgs e)
        {
            (e.Page.BindingContext as IPoppedAware)?.OnPopped();
        }

        private void OnPoppedToRoot(object sender, NavigationEventArgs e)
        {
            (e.Page.BindingContext as IPoppedToRootAware)?.OnPoppedToRoot();
        }
    }
}
