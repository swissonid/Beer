using Android.App;
using Android.OS;
using Android.Support.V7.App;


namespace Beer.Droid
{
    [Activity(Label = "Beer", Theme ="@style/SplashTheme", MainLauncher = true)]
    public class SplashScreenActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            MainActivity.StartMainActivity(this);
            Finish();
        }
    }
}
