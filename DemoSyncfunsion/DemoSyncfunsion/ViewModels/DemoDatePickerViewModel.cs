using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoSyncfunsion.ViewModels
{
    public class DemoDatePickerViewModel : ViewModelBase
    {
        public DemoDatePickerViewModel(INavigationService navigationService)
            : base(navigationService)
        {

        }
    }
}
