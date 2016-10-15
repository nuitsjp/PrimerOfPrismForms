using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlueMonkey.ViewModels
{
    public class ExpensePageViewModel : BindableBase
    {
        public DelegateCommand SaveCommand { get; private set; }
        public ExpensePageViewModel()
        {
            SaveCommand = new DelegateCommand(Save);
        }

        private void Save()
        {
        }
    }
}
