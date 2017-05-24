using Prism.Mvvm;
using Xamarin.Forms;

namespace NavigationBarTitleSample.ViewModels
{
	public class MyNavigationPageViewModel : BindableBase
	{
		public Color TitleColor { get; set; } = Color.Green;
	}
}
