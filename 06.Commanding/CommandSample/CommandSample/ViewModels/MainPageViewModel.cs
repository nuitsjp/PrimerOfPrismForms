using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace CommandSample.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set { SetProperty(ref _firstName, value); }
        }
        private string _familyName;
        public string FamilyName
        {
            get { return _familyName; }
            set { SetProperty(ref _familyName, value); }
        }

        public ICommand NameCommand { get; }

        private bool _isToggled;

        public bool IsToggled
        {
            get { return _isToggled; }
            set { SetProperty(ref _isToggled, value); }
        }
        public ICommand ToggleCommand { get; }

        public CompositeCommand CompositeCommand { get; }

        public MainPageViewModel()
        {
            // bool型以外のプロパティの変更を監視したい場合
            NameCommand =
                new DelegateCommand(() => { }, CanExecuteNameCommand)
                    .ObservesProperty(() => FirstName)
                    .ObservesProperty(() => FamilyName);
            // 監視対象のプロパティの型がboolの場合
            ToggleCommand = new DelegateCommand(() => { }).ObservesCanExecute(_=> IsToggled);
            // 複合コマンド
            CompositeCommand = new CompositeCommand();
            CompositeCommand.RegisterCommand(NameCommand);
            CompositeCommand.RegisterCommand(ToggleCommand);
        }

        private bool CanExecuteNameCommand()
        {
            return !string.IsNullOrWhiteSpace(FirstName)
                   && !string.IsNullOrWhiteSpace(FamilyName);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
