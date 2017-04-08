using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace MasterDetailSample.ViewModels
{
    public class DetailPageCViewModel : ViewModelBase
    {
        public DetailPageCViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}
