using Android.App;
using Android.Content;
using Android.Support.V7.App;

namespace StarkovInteractiveCV.Droid
{
    [Activity(Theme = "@style/MainThemeSplash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }

        public override void OnBackPressed() { }
    }
}
