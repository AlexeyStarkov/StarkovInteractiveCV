using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using StarkovInteractiveCV.Enums;
using Plugin.CurrentActivity;
using Prism.Ioc;
using StarkovInteractiveCV.Interfaces;
using Android.Content;
using Android.Preferences;

namespace StarkovInteractiveCV.Droid
{
    [Activity(Label = "StarkovInteractiveCV", Icon = "@mipmap/icon", Theme = "@style/MainLightTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
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
            
            base.OnCreate(savedInstanceState);
            CrossCurrentActivity.Current.Init(this, savedInstanceState);

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

            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}