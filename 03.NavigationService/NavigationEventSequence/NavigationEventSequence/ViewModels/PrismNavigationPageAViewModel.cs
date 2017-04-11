using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace NavigationEventSequence.ViewModels
{
    public class PrismNavigationPageAViewModel : ViewModelBase
    {
        public PrismNavigationPageAViewModel(INavigationService navigationService) : base(navigationService)
        {
        }
    }
}
