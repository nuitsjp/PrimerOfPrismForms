using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Prism;
using Prism.Navigation;

namespace TabbedPageNavigation.ViewModels
{
    public class PrismContentPage1ViewModel : BindableBase, IActiveAware
    {
        public ICommand GoNextCommand { get; }
        public PrismContentPage1ViewModel(INavigationService navigationService)
        {
            GoNextCommand = new DelegateCommand(() =>
            {
                navigationService.NavigateAsync("PrismContentPage2");
            });
        }

        #region IActiveAware Members

        private bool _isActive;

        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                if (_isActive != value)
                {
                    _isActive = value;
                    OnActiveChanged(this, EventArgs.Empty);
                }
            }
        }

        private void OnActiveChanged(object sender, EventArgs e)
        {
            IsActiveChanged?.Invoke(sender, e);
        }

        public event EventHandler IsActiveChanged;
        #endregion
    }
}
