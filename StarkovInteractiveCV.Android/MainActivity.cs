using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Preferences;
using Android.Runtime;
using FFImageLoading.Forms.Platform;
using FFImageLoading.Svg.Forms;
using Plugin.CurrentActivity;
using Rg.Plugins.Popup.Services;
using StarkovInteractiveCV.Enums;

namespace StarkovInteractiveCV.Droid
{
    [Activity(Theme = "@style/MainLightTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        internal static MainActivity Instance { get; private set; }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Instance = this;

            var preferences = PreferenceManager.GetDefaultSharedPreferences(this);
            var styleTheme = (StyleTheme)preferences.GetInt(nameof(StyleTheme), 0);
            if (styleTheme == StyleTheme.Light)
                SetTheme(Resource.Style.MainLightTheme);
            else
                SetTheme(Resource.Style.MainDarkTheme);

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            CrossCurrentActivity.Current.Init(this, savedInstanceState);

            base.OnCreate(savedInstanceState);
            SvgCachedImage.Init();
            CachedImageRenderer.Init(false);
            Forms9Patch.Droid.Settings.Initialize(this);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        internal void SetStyleTheme(StyleTheme theme)
        {
            var preferences = PreferenceManager.GetDefaultSharedPreferences(this).Edit();
            preferences.PutInt(nameof(StyleTheme), (int)theme);
            preferences.Apply();
        }

        internal void RestartActivity()
        {
            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }

        public override async void OnBackPressed()
        {
            if (Rg.Plugins.Popup.Popup.SendBackPressed(base.OnBackPressed))
            {
                await PopupNavigation.Instance.PopAsync();
            }
        }
    }
}