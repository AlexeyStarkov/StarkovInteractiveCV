using Rg.Plugins.Popup.Pages;
using StarkovInteractiveCV.Interfaces;
using Xamarin.Forms;

namespace StarkovInteractiveCV.VisualElements.BaseObjects
{
    public abstract class PopupPageBase : PopupPage
    {
        protected virtual Layout LayoutToCorrectBottomPadding => null;

        protected override void OnParentSet()
        {
            if (LayoutToCorrectBottomPadding != null)
            {
                var nextButtonBottomMargin = DependencyService.Get<IDeviceSpecificTools>().GetVirtualButtonsAreaHeight();

                LayoutToCorrectBottomPadding.Padding = new Thickness(LayoutToCorrectBottomPadding.Padding.Left, LayoutToCorrectBottomPadding.Padding.Top, LayoutToCorrectBottomPadding.Padding.Right, LayoutToCorrectBottomPadding.Padding.Bottom + nextButtonBottomMargin);
            }

            base.OnParentSet();
        }
    }
}
