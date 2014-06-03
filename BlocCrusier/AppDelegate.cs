using Microsoft.Xna.Framework;
using Cocos2D;

namespace BlocCrusier
{
    public class AppDelegate : CCApplication
    {
        const int PreferredWidth = 480;
        const int PreferredHeight = 320;

        public AppDelegate(Game game, GraphicsDeviceManager graphics) : base(game, graphics)
        {
            s_pSharedApplication = this;
            
            graphics.PreferredBackBufferWidth = PreferredWidth;
            graphics.PreferredBackBufferHeight = PreferredHeight;

            CCDrawManager.InitializeDisplay(
                game,
                graphics,
                DisplayOrientation.LandscapeRight | DisplayOrientation.LandscapeLeft);

            graphics.PreferMultiSampling = false;

        }
        public override bool ApplicationDidFinishLaunching()
        {
            CCDirector.SharedDirector.SetOpenGlView();
            CCDirector.SharedDirector.Projection = CCDirectorProjection.Projection2D;
            CCDrawManager.SetDesignResolutionSize(PreferredWidth, PreferredHeight, CCResolutionPolicy.ShowAll);
            CCDirector.SharedDirector.DisplayStats = true;
            CCDirector.SharedDirector.AnimationInterval = 1.0 / 60;
            CCDirector.SharedDirector.RunWithScene(IntroLayer.Scene);
            
            return true;
        }

        public override void ApplicationDidEnterBackground()
        {
            CCDirector.SharedDirector.Pause();
        }

        public override void ApplicationWillEnterForeground()
        {
            CCDirector.SharedDirector.Resume();
        }
    }
}