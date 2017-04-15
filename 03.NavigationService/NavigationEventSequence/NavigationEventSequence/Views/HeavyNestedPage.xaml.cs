using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class HeavyNestedPage : MasterDetailPage
    {
        public HeavyNestedPage()
        {
            InitializeComponent();
            this.SetLogger();
        }
    }
}