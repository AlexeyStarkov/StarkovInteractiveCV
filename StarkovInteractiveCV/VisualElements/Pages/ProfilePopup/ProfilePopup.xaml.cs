using StarkovInteractiveCV.VisualElements.BaseObjects;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.Pages.ProfilePopup
{
    public partial class ProfilePopup : PopupPageBase
    {
        protected override Layout LayoutToCorrectBottomPadding => ScrollContainer;

        public ProfilePopup()
        {
            InitializeComponent();
        }
    }
}
