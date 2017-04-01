using Prism.Behaviors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PageDialogBehavior.Views.Behaviors
{
    public class DisplayAlertBehavior : EventToCommandBehavior
    {
        public static readonly BindableProperty TitleProperty =
            BindableProperty.Create(nameof(Title), typeof(string), typeof(DisplayAlertBehavior));

        public static readonly BindableProperty MessageProperty =
            BindableProperty.Create(nameof(Message), typeof(string), typeof(DisplayAlertBehavior));

        public static readonly BindableProperty AcceptProperty =
            BindableProperty.Create(nameof(Accept), typeof(string), typeof(DisplayAlertBehavior));

        public static readonly BindableProperty CancelProperty =
            BindableProperty.Create(nameof(Cancel), typeof(string), typeof(DisplayAlertBehavior));


        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string Message
        {
            get { return (string)GetValue(MessageProperty); }
            set { SetValue(MessageProperty, value); }
        }

        public string Accept
        {
            get { return (string)GetValue(AcceptProperty); }
            set { SetValue(AcceptProperty, value); }
        }

        public string Cancel
        {
            get { return (string)GetValue(CancelProperty); }
            set { SetValue(CancelProperty, value); }
        }

        protected override async void OnEventRaised(object sender, EventArgs eventArgs)
        {
            var currentPage = Application.Current.MainPage.Navigation.NavigationStack.FirstOrDefault();
            if(currentPage != null)
            {
                if(string.IsNullOrEmpty(Accept))
                {
                    await currentPage.DisplayAlert(Title, Message, Cancel);
                    base.OnEventRaised(sender, eventArgs);
                }
                else
                {
                    var result = await currentPage.DisplayAlert(Title, Message, Accept, Cancel);
                    if(result)
                    {
                        base.OnEventRaised(sender, eventArgs);
                    }
                }
            }
        }
    }
}
