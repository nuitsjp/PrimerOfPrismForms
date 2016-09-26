using Xamarin.Forms;

namespace NavigationSample.Views
{
    public partial class MyNavigationPage : NavigationPage
    {
        public MyNavigationPage()
        {
            InitializeComponent();
        }

        private void MyNavigationPage_OnPushed(object sender, NavigationEventArgs e)
        {
            (e.Page.BindingContext as IPushedAware)?.OnPushed();
        }

        private void MyNavigationPage_OnPopped(object sender, NavigationEventArgs e)
        {
            (e.Page.BindingContext as IPoppedAware)?.OnPopped();
        }

        private void MyNavigationPage_OnPoppedToRoot(object sender, NavigationEventArgs e)
        {
            (e.Page.BindingContext as IPoppedToRootAware)?.OnPoppedToRoot();
        }
    }
}
