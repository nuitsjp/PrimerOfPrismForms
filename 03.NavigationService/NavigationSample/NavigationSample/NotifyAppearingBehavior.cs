﻿using System;
using System.Reflection;
using System.Windows.Input;
using Xamarin.Forms;

namespace NavigationSample
{
    /// <summary>
    /// アタッチしているオブジェクトで特定のイベントを購読し、イベント発行時にバインドされたコマンドを実行するビヘイビア
    /// </summary>
    public class NotifyAppearingBehavior : BindableBehavior<Page>
    {
        /// <summary>
        /// アタッチ時に、対象のイベントの購読設定を行う
        /// </summary>
        /// <param name="bindable"></param>
        protected override void OnAttachedTo(Page bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.Appearing += OnAppearing;
            bindable.Disappearing += OnDisappearing;
        }

        /// <summary>
        /// デタッチ時に、イベントの購読を解除する
        /// </summary>
        /// <param name="bindable"></param>
        protected override void OnDetachingFrom(Page bindable)
        {
            bindable.Disappearing -= OnDisappearing;
            bindable.Appearing -= OnAppearing;
            base.OnDetachingFrom(bindable);
        }

        private void OnAppearing(object sender, EventArgs eventArgs)
        {
            (AssociatedObject.BindingContext as IAppearingAware)?.OnAppearing();
        }

        private void OnDisappearing(object sender, EventArgs eventArgs)
        {
            (AssociatedObject.BindingContext as IDisappearingAware)?.OnDisappearing();
        }
    }
}
