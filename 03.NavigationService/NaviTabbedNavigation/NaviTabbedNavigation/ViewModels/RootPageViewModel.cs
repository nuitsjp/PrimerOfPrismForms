using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism.Navigation;
using Xamarin.Forms;

namespace NaviTabbedNavigation.ViewModels
{
    public class RootPageViewModel : BindableBase
    {
        private readonly INavigationService _navigationService;

        public List<MasterPageItem> MasterPageItems { get; } = new List<MasterPageItem>
        {
            new MasterPageItem
            {
                //ImageSource =
                //    ImageSource.FromResource("CamsOffSiteMeetingApp.Resources.Images.ic_schedule_black_24dp.png"),
                Title = "スケジュール",
                PageName = "ScheduleTabbedPage"
            }
        };

        public RootPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public ICommand NavigateCommand => new Command<MasterPageItem>(async item =>
        {
            if (item == null)
            {
                return;
            }
            await _navigationService.NavigateAsync($"MyNavigationPage/{item.PageName}/SchedulePage");
        });
    }
}
