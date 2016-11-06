using Prism.Navigation;
using Xamarin.Forms;

namespace MasterDetailSample.Views
{
    public partial class MainPage : MasterDetailPage, IMasterDetailPageOptions
    {
        public bool IsPresentedAfterNavigation => true;
        public MainPage()
        {
            InitializeComponent();
        }
    }
}