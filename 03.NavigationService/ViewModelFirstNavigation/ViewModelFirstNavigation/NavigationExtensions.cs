using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Unity;
using Xamarin.Forms;

namespace ViewModelFirstNavigation
{
    public static class NavigationExtensions
    {
        public static IUnityContainer RegisterTypeForViewModelNavigation<TView, TViewModel>(this IUnityContainer container)
            where TView : Page
            where TViewModel : class
        {
            var viewType = typeof(TView);
            ViewModelLocationProvider.Register(viewType.ToString(), typeof(TViewModel));
            return container.RegisterTypeForNavigation(viewType, typeof(TViewModel).FullName);
        }

        public static IUnityContainer RegisterTypeForViewModelNavigationOnPlatform<TView, TViewModel>(this IUnityContainer container, Type androidView = null, Type iOSView = null, Type otherView = null, Type windowsView = null, Type winPhoneView = null)
            where TView : Page
            where TViewModel : class
        {
            return container.RegisterTypeForNavigationOnPlatform<TView, TViewModel>(typeof(TViewModel).FullName, androidView, iOSView, otherView, windowsView, winPhoneView);
        }

        public static IUnityContainer RegisterTypeForViewModelNavigationOnIdiom<TView, TViewModel>(this IUnityContainer container, Type desktopView = null, Type tabletView = null, Type phoneView = null)
            where TView : Page
            where TViewModel : class
        {
            return container.RegisterTypeForNavigationOnIdiom<TView, TViewModel>(typeof(TViewModel).FullName, desktopView, tabletView, phoneView);
        }

        /// <summary>
        /// Initiates navigation to the target specified by the <typeparamref name="TViewModel"/>.
        /// </summary>
        /// <typeparam name="TViewModel">The type which will be used to identify the name of the navigation target.</typeparam>
        /// <param name="parameters">The navigation parameters</param>
        /// <param name="useModalNavigation">If <c>true</c> uses PopModalAsync, if <c>false</c> uses PopAsync</param>
        /// <param name="animated">If <c>true</c> the transition is animated, if <c>false</c> there is no animation on transition.</param>
        public static Task NavigateAsync<TViewModel>(this INavigationService navigationService, NavigationParameters parameters = null, bool? useModalNavigation = null, bool animated = true)
            where TViewModel : BindableBase
        {
            return navigationService.NavigateAsync(typeof(TViewModel).FullName, parameters, useModalNavigation, animated);
        }
    }
}
