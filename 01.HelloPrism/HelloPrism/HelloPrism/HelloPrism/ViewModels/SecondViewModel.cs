using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HelloPrism.ViewModels
{
    public class SecondViewModel : BindableBase
    {
        public string Message { get; set; } = "Hello, Second Page.";
        public SecondViewModel()
        {

        }
    }
}
