using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace DemoSyncfunsion.ViewModels
{
    public class DemoPopupLayoutViewModel : ViewModelBase
    {
        private bool _iopen = false;
        public bool IOpen
        {
            get { return _iopen; }
            set { SetProperty(ref _iopen, value); }
        }
        public Command Clickedbnt;
        public DemoPopupLayoutViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Clickedbnt = new Command(ClickBnt);

        }
        public void ClickBnt()
        {
            IOpen = true;
            return;
        }
    }
}
