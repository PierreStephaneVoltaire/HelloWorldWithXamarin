using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloWorldWithXamarin
{
    [Activity(Label = "HelloWorldWithXamarin", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        //variables to get the widgets on the activity
        Button btn;
        TextView hello;
        EditText name;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
             SetContentView (Resource.Layout.Main);
           // initialize widgets
            name =FindViewById< EditText > (Resource.Id.name);
            hello = FindViewById<TextView>(Resource.Id.Hello);
            btn = FindViewById<Button>(Resource.Id.button1);
            //set the name when the button is clicked
            btn.Click += delegate {
                if (!string.IsNullOrWhiteSpace(name.Text))
                    hello.Text = "Hello " + name.Text;
                else
                    hello.Text = "Hello world";
            };

        }
    }
}

