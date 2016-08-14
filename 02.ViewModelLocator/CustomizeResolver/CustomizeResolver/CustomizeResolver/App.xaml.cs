using System;
using System.Globalization;
using System.Reflection;
using Prism.Unity;
using CustomizeResolver.Views;
using Prism.Mvvm;

namespace CustomizeResolver
{
    public partial class App
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("MainPage?title=Hello%20from%20Xamarin.Forms");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
        }

        /// <summary>
        /// 「～Page」のViewModelの名称を、「～PageViewModel」から「～ViewModel」に変更する
        /// </summary>
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();   // <- 必須！DIされなくなります。
            ViewModelLocationProvider.SetDefaultViewTypeToViewModelTypeResolver(
                viewType =>
                {
                    var viewName = viewType.FullName;
                    viewName = viewName.Replace(".Views.", ".ViewModels.");
                    string viewModelName;
                    if (viewName.EndsWith("Page"))
                    {
                        viewModelName = $"{viewName.Substring(0, viewName.LastIndexOf("Page", StringComparison.Ordinal))}ViewModel";
                    }
                    else
                    {
                        var suffix = viewName.EndsWith("View") ? "Model" : "ViewModel";
                        viewModelName = $"{viewName}{suffix}";
                    }
                    var viewAssemblyName = viewType.GetTypeInfo().Assembly.FullName;
                    return Type.GetType(string.Format(CultureInfo.InvariantCulture, "{0}, {1}", viewModelName, viewAssemblyName));
                });
        }
    }
}
