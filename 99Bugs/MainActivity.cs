using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;


namespace _99Bugs
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        int count = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;

            var aLabel = new TextView(this);
            aLabel.SetText(Resource.String.label_text);

            //var aButton = FindViewById<Button>(Resource.Id.takeonedownButton);

            var aButton = new Button(this);
            aButton.SetText(Resource.String.button_text1);

            aButton.Click += (sender, e) =>
            {
                var scrn2 = new Intent(this, typeof(SecondActivity));
                scrn2.PutExtra("stuff", true);
                StartActivity(scrn2);
            };

            var aButtonT2 = new Button(this);
            aButtonT2.SetText(Resource.String.button_text2);

            aButtonT2.Click += (sender, e) =>
            {
                var scrn2 = new Intent(this, typeof(SecondActivity));
                scrn2.PutExtra("stuff", false);
                StartActivity(scrn2);
            };

            /*
            showSecond.Click += (sender, e) => {
                var second = new Intent(this, typeof(SecondActivity));
                second.PutExtra("FirstData", "Data from FirstActivity");
                StartActivity(second);
            };

            aButton.Click += (sender, e) =>
            {
                aLabel.Text = (++count).ToString() + "Bugs In the Light";
            };

            aButtonT2.Click += (sender, e) =>
            {
                aLabel.Text = (++count + 1).ToString() + "Bugs In the Light";
            };
            */

            //create our widgets
            layout.AddView(aLabel);
            layout.AddView(aButton);
            layout.AddView(aButtonT2);
            SetContentView(layout);

        }
    }
}