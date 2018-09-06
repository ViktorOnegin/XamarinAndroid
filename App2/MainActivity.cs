using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace App2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var count = 0;
            var textView = FindViewById<TextView>(Resource.Id.textView1);
            var button = FindViewById<Button>(Resource.Id.button1);
            var Activity1Button = FindViewById<Button>(Resource.Id.button2);

            button.Click += delegate
            {
                count++;
                textView.Text = "Vajutasid Nuppu" + count + "korda";
            };

            var SecondActivityButton = FindViewById<Button>(Resource.Id.button2);
            SecondActivityButton.Click += SecondActivityButton_Click;

            var ThirdActivityButton = FindViewById<Button>(Resource.Id.button3);
            ThirdActivityButton.Click += thirdActivityButton_Click;

        }

        private void thirdActivityButton_Click(object sender, System.EventArgs e)
        {
            var ThirdActivity = new Intent(this, typeof(ThirdActivity));
            StartActivity(ThirdActivity);
        }

        private void SecondActivityButton_Click(object sender, System.EventArgs e)
        {
            var SecondActivity = new Intent(this, typeof(SecondActivity));
            StartActivity(SecondActivity);
        }
    }
}