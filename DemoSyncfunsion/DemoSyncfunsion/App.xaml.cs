using DemoSyncfunsion.ViewModels;
using DemoSyncfunsion.Views;
using Prism;
using Prism.Ioc;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace DemoSyncfunsion
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("NavigationPage/DemoPullRefresh");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<demoDataForm, demoDataFormViewModel>();
            containerRegistry.RegisterForNavigation<DemoDatePicker, DemoDatePickerViewModel>();
            containerRegistry.RegisterForNavigation<DemoDigitalGauge, DemoDigitalGaugeViewModel>();
            containerRegistry.RegisterForNavigation<DemoEffectView, DemoEffectViewViewModel>();
            containerRegistry.RegisterForNavigation<DemoExpander, DemoExpanderViewModel>();
            containerRegistry.RegisterForNavigation<DemoGradientView, DemoGradientViewViewModel>();
            containerRegistry.RegisterForNavigation<DemoImageEditor, DemoImageEditorViewModel>();
            containerRegistry.RegisterForNavigation<DemoKanban, DemoKanbanViewModel>();
            containerRegistry.RegisterForNavigation<DemoMaskEdit, DemoMaskEditViewModel>();
            containerRegistry.RegisterForNavigation<DemoNumericTextBox, DemoNumericTextBoxViewModel>();
            containerRegistry.RegisterForNavigation<NumericUpdown, NumericUpdownViewModel>();
            containerRegistry.RegisterForNavigation<ParallaxView, ParallaxViewViewModel>();
            containerRegistry.RegisterForNavigation<DemoPopupLayout, DemoPopupLayoutViewModel>();
            containerRegistry.RegisterForNavigation<DemoPullRefresh, DemoPullRefreshViewModel>();
            containerRegistry.RegisterForNavigation<DemoRadioButton, DemoRadioButtonViewModel>();
            containerRegistry.RegisterForNavigation<DemoRadialMenu, DemoRadialMenuViewModel>();
            containerRegistry.RegisterForNavigation<DemoRangeSlider, DemoRangeSliderViewModel>();
            containerRegistry.RegisterForNavigation<DemoRating, DemoRatingViewModel>();
            containerRegistry.RegisterForNavigation<DemoShimmer, DemoShimmerViewModel>();
            containerRegistry.RegisterForNavigation<DemoSegmentControl, DemoSegmentControlViewModel>();
        }          
    }
}
