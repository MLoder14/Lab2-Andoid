using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace _99Bugs
{
    [Activity(Label = "SecondActivity", ParentActivity = typeof(MainActivity))]
    public class SecondActivity : Activity
    {
        int count = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var layout = new LinearLayout(this);
            layout.Orientation = Orientation.Vertical;

            var aLabelwq = new TextView(this);
            aLabelwq.SetText(Resource.String.label_text2);

            if(Intent.GetBooleanExtra("stuff", true))
            {
                aLabelwq.Text = (++count).ToString() + "Bugs In the Light";
            }
            else
            {
                aLabelwq.Text = (1 + ++count).ToString() + "Bugs In the Light";
            }

            layout.AddView(aLabelwq);
            SetContentView(layout);
        }
    }
}