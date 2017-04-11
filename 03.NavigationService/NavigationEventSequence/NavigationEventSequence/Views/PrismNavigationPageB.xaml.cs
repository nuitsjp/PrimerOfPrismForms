using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class PrismNavigationPageB : NavigationPage
    {
        public PrismNavigationPageB()
        {
            InitializeComponent();
            this.SetLogger();
        }

        public PrismNavigationPageB(Page page) : base(page)
        {
            InitializeComponent();
            this.SetLogger();
        }
    }
}
