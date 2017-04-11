using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class PrismNavigationPageA : NavigationPage
    {
        public PrismNavigationPageA()
        {
            InitializeComponent();
            this.SetLogger();
        }
        public PrismNavigationPageA(Page page) : base(page)
        {
            InitializeComponent();
            this.SetLogger();
        }
    }
}
