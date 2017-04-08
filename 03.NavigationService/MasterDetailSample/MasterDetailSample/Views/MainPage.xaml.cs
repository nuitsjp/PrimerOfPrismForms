using Prism.Navigation;
using Xamarin.Forms;

namespace MasterDetailSample.Views
{
    public partial class MainPage : MasterDetailPage, IMasterDetailPageOptions
    {
        public bool IsPresentedAfterNavigation
        {
            get { return Device.Idiom != TargetIdiom.Phone; }
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}