using Android.App;
using Android.Widget;
using Android.OS;

namespace HelloWorldWithXamarin
{
    [Activity(Label = "HelloWorldWithXamarin", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btn;
        TextView hello;
        EditText name;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
// Set our view from the "main" layout resource
             SetContentView (Resource.Layout.Main);


            name =FindViewById< EditText > (Resource.Id.name);
            hello = FindViewById<TextView>(Resource.Id.Hello);
            btn = FindViewById<Button>(Resource.Id.button1);
            btn.Click += delegate {
                if (!string.IsNullOrWhiteSpace(name.Text))
                    hello.Text = "Hello " + name.Text;
                else
                    hello.Text = "Hello world";
            };

        }
    }
}

