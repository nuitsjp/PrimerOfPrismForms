using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace MasterDetailSample.ViewModels
{
    public class DetailPageBViewModel : ViewModelBase
    {
        public DetailPageBViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}
