using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace MasterDetailSample.ViewModels
{
    public class DetailPageAViewModel : ViewModelBase
    {
        public DetailPageAViewModel(INavigationService navigationService)
            : base(navigationService)
        {
        }
    }
}
