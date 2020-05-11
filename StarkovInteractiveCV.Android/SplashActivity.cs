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
            if (MainActivity.Instance == null)
            {
                StartActivity(new Intent(Application.Context, typeof(MainActivity)));
            }
            else
            {
                Finish();
            }
            
            base.OnResume();
        }

        public override void OnBackPressed() { }
    }
}
