using Android.Content.PM;
using Android.App;
using Android.OS;
using Android.Widget;
using Microsoft.Xna.Framework;

namespace BlocCrusier
{

    [Activity(Label = "BlocCrusier"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = Android.Content.PM.LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.SensorLandscape
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden)]
    public class Program : AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            BlocCruiserGame.Activity = this;
            var game = new BlocCruiserGame();

            var frameLayout = new FrameLayout(this);
            frameLayout.AddView(game.Window);
            this.SetContentView(frameLayout);

            //SetContentView(game.Window);
            game.Run(GameRunBehavior.Asynchronous);
        }
    }


}

