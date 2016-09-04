using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PageDialogService.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IPageDialogService _pageDialogService;
        public ICommand DisplayDialogCommand { get; }
        public ICommand DisplayActionSheetCommand { get; }
        public MainPageViewModel(IPageDialogService pageDialogService)
        {
            _pageDialogService = pageDialogService;
            DisplayDialogCommand = new DelegateCommand(async () =>
            {
                //await _pageDialogService.DisplayAlertAsync("Title", "Hello, Dialog.", "OK");
                var result = await _pageDialogService.DisplayAlertAsync("Title", "何れかを選んでください。", "はい", "いいえ");
                await _pageDialogService.DisplayAlertAsync("Title", $"選択結果：{result}", "OK");
            });
            DisplayActionSheetCommand = new DelegateCommand(async () =>
            {
                //var result = await _pageDialogService.DisplayActionSheetAsync("共有先を選択してください。", "キャンセル", "削除", "Twitter", "LINE", "Facebook");
                //await _pageDialogService.DisplayAlertAsync("Title", $"選択結果：{result}", "OK");
                var cancelButton = 
                    ActionSheetButton.CreateCancelButton(
                        "キャンセル", 
                        new DelegateCommand(
                            async () => await DisplayAlert("キャンセル")));
                var deleteButton = ActionSheetButton.CreateDestroyButton("削除", new DelegateCommand(async () => await DisplayAlert("削除")));
                var twitterButton = ActionSheetButton.CreateButton("Twitter", new DelegateCommand(async () => await DisplayAlert("Twitter")));
                var lineButton = ActionSheetButton.CreateButton("LINE", new DelegateCommand(async () => await DisplayAlert("LINE")));
                var facebookButton = ActionSheetButton.CreateButton("Facebook", new DelegateCommand(async () => await DisplayAlert("Facebook")));
                await _pageDialogService.DisplayActionSheetAsync("共有先を選択してください。", cancelButton, deleteButton, twitterButton, lineButton, facebookButton);
            });
        }

        private async Task DisplayAlert(string message)
        {
            await _pageDialogService.DisplayAlertAsync("Title", $"選択結果：{message}", "OK");
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
