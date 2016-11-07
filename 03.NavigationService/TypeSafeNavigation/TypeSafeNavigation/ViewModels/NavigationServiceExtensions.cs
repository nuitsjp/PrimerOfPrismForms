using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;

namespace TypeSafeNavigation.ViewModels
{
    public static class NavigationServiceExtensions
    {
        public static Task NavigateAsync(this INavigationService navigationService, params NavigateDestination[] navigatesDestination)
        {
            return navigationService.NavigateAsync(navigatesDestination.Select(x => new Navigation(x)).ToArray());
        }

        public static Task NavigateAsync(this INavigationService navigationService, params Navigation[] navigations)
        {
            var builder = new StringBuilder();
            var delim = String.Empty;
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
