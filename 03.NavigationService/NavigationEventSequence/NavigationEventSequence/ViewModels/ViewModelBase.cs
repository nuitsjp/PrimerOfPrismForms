using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Prism;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace NavigationEventSequence.ViewModels
{
    public class ViewModelBase : BindableBase, INavigationAware, IActiveAware
    {
        private readonly INavigationService _navigationService;

        public DelegateCommand<string> NavigationCommand
            => new DelegateCommand<string>(x => _navigationService.NavigateAsync(x));
        public DelegateCommand GoBackCommand => new DelegateCommand(() => _navigationService.GoBackAsync());
        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            WriteLog();
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            WriteLog();
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            WriteLog();
        }

        private bool _isActive;

        public ViewModelBase(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public bool IsActive
        {
            get
            {
                WriteLog($"get {_isActive}");
                return _isActive;
            }
            set
            {
                WriteLog($"set {value}");
                _isActive = value;
            }
        }

        public event EventHandler IsActiveChanged;

        private void WriteLog(object value = null, [CallerMemberName] string callerMemberName = null)
        {
            Debug.WriteLine($"{GetType().Name}#{callerMemberName} {value ?? string.Empty}");
        }
    }
}
