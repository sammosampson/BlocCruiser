using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Cocos2D;

namespace BlocCrusier
{
    public class BlocCruiserGame : Game
    {
        private readonly GraphicsDeviceManager graphics;

        public BlocCruiserGame()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.IsFullScreen = false;
            TargetElapsedTime = TimeSpan.FromTicks(333333 / 2);
            Components.Add(new BlocCruiserApplication(this, graphics));
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                ProcessBackClick();

            base.Update(gameTime);
        }

        void ProcessBackClick()
        {
            if (CCDirector.SharedDirector.CanPopScene)
                CCDirector.SharedDirector.PopScene();
            else
                Exit();
        }
    }
}