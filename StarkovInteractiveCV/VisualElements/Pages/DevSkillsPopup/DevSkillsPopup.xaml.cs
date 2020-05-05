using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.DevSkillsPopup
{
    public partial class DevSkillsPopup : PopupPageBase
    {
        protected override Layout LayoutToCorrectBottomPadding => ScrollContainer;

        public DevSkillsPopup()
        {
            InitializeComponent();
        }
    }
}
