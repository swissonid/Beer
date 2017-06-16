using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Support.V7.App;
using Android.OS;

namespace Beer.Droid
{
    [Activity(Label = "Beer.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }

        public static void StartMainActivity(AppCompatActivity activity)  
        {
            var startIntent = new Intent(activity, typeof(MainActivity));
            activity.StartActivity(startIntent);
        }
    }
}
