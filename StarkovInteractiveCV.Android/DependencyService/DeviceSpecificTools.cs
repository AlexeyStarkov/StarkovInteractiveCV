using Android.Content.Res;
using Plugin.CurrentActivity;
using StarkovInteractiveCV.Droid.DependencyService;
using StarkovInteractiveCV.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceSpecificTools))]
namespace StarkovInteractiveCV.Droid.DependencyService
{
    public class DeviceSpecificTools : IDeviceSpecificTools
    {
        public double GetVirtualButtonsAreaHeight()
        {
            int id = Resources.System.GetIdentifier("config_showNavigationBar", "bool", "android");
            var hasSoftButtons = id > 0 && Resources.System.GetBoolean(id);

            if (hasSoftButtons)
            {
                return GetHeightByResourceName("navigation_bar_height");
            }

            return 0;
        }

        private double GetHeightByResourceName(string resourceName)
        {
            int resourceId = Resources.System.GetIdentifier(resourceName, "dimen", "android");
            if (resourceId > 0)
            {
                var pxHeight = (double)Resources.System.GetDimensionPixelSize(resourceId);
                var metrics = CrossCurrentActivity.Current.Activity.ApplicationContext.Resources.DisplayMetrics;
                return pxHeight / metrics.Density;
            }
            return 0;
        }
    }
}
