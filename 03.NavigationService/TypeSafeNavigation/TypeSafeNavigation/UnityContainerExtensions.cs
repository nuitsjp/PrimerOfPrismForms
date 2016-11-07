using Prism.Unity;
using Microsoft.Practices.Unity;
using TypeSafeNavigation.ViewModels;
using Xamarin.Forms;

namespace TypeSafeNavigation
{
    public static class UnityContainerExtensions
    {
        public static IUnityContainer RegisterTypeForNavigation<TView>(this IUnityContainer unityContainer, NavigateDestination navigateDestination) where TView : Page
        {
            return unityContainer.RegisterTypeForNavigation<TView>(navigateDestination.ToString());
        }
    }
}