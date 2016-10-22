
using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;

namespace DiagonalLayout.Sample
{
    [Activity(Label = "AnimActivity", Theme = "@style/AppTheme")]
    public class AnimActivity : AppCompatActivity
    {
        View layoutTop;
        View layoutBottom;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main_simple);


            layoutTop = FindViewById(Resource.Id.layoutTop);
            layoutBottom = FindViewById(Resource.Id.layoutBottom);
        }
    }
}
