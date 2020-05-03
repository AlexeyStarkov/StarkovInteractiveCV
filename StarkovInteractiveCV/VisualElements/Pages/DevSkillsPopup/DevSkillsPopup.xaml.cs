using Rg.Plugins.Popup.Pages;
using StarkovInteractiveCV.Interfaces;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.DevSkillsPopup
{
    public partial class DevSkillsPopup : PopupPage
    {
        public DevSkillsPopup()
        {
            InitializeComponent();
        }

        protected override void OnParentSet()
        {
            var nextButtonBottomMargin = DependencyService.Get<IDeviceSpecificTools>().GetVirtualButtonsAreaHeight();
            
            ScrollContainer.Padding = new Thickness(ScrollContainer.Padding.Left, ScrollContainer.Padding.Top, ScrollContainer.Padding.Right, ScrollContainer.Padding.Bottom + nextButtonBottomMargin);

            base.OnParentSet();
        }
    }
}
