﻿using System.Diagnostics;
using Xamarin.Forms;

namespace NavigationEventSequence.Views
{
    public partial class MyNavigationPage : NavigationPage
    {
        public MyNavigationPage()
        {
            Debug.WriteLine("MyNavigationPage#Constructor()");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("MyNavigationPage#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("MyNavigationPage#Disappearing");
        }

        public MyNavigationPage(Page page) : base(page)
        {
            Debug.WriteLine("MyNavigationPage#Constructor(Page)");
            InitializeComponent();
            Appearing += (sender, args) => Debug.WriteLine("MyNavigationPage#Appearing");
            Disappearing += (sender, args) => Debug.WriteLine("MyNavigationPage#Disappearing");
        }
    }
}
