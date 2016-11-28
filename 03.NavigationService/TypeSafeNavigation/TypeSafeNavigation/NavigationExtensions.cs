using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using Prism.Navigation;
using Prism.Unity;
using Xamarin.Forms;

namespace TypeSafeNavigation
{
    /// <summary>
    /// 画面遷移関連の拡張メソッド集合
    /// </summary>
    public static class NavigationExtensions
    {
        public static IUnityContainer RegisterTypeForNavigation<TView>(this IUnityContainer unityContainer, NavigateDestination navigateDestination) where TView : Page
        {
            return unityContainer.RegisterTypeForNavigation<TView>(navigateDestination.ToString());
        }

        public static Task NavigateAsync(this INavigationService navigationService, params NavigateDestination[] navigatesDestination)
        {
            return navigationService.NavigateAsync(navigatesDestination.Select(x => new Navigation(x)).ToArray());
        }

        public static Task NavigateAsync(this INavigationService navigationService, params Navigation[] navigations)
        {
            var builder = new StringBuilder();
            var delim = string.Empty;
            foreach (var navigation in navigations)
            {
                builder.Append(delim);
                builder.Append(navigation.ToString());
                delim = "/";
            }
            return navigationService.NavigateAsync(builder.ToString());
        }
    }
}
