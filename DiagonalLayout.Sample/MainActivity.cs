using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Support.V7.Widget;

namespace DiagonalLayout.Sample
{
    [Activity(Label = "DiagonalLayout.Sample", MainLauncher = true, Icon = "@mipmap/icon", Theme="@style/AppTheme")]
    public class MainActivity : AppCompatActivity
    {
        Toolbar toolbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main_simple);

            toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
        }
    }
}

