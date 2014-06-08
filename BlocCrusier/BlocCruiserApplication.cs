using Microsoft.Xna.Framework;
using Cocos2D;

namespace BlocCrusier
{
    public class BlocCruiserApplication : CCApplication
    {
        const int PreferredWidth = 480;
        const int PreferredHeight = 320;

        public BlocCruiserApplication(Game game, GraphicsDeviceManager graphics) : base(game, graphics)
        {
            s_pSharedApplication = this;
            
            //graphics.PreferredBackBufferWidth = (int)CCDirector.SharedDirector.WinSize.Width;
            //graphics.PreferredBackBufferHeight = (int)CCDirector.SharedDirector.WinSize.Height;

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
            CCDirector.SharedDirector.RunWithScene(new GameScene());
            
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