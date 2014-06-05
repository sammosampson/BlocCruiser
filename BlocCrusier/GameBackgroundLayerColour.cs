using Cocos2D;

namespace BlocCrusier
{
    public class IntroLayer : CCLayerColor
    {
        public IntroLayer()
        {
            AddChild(CreateLabel());
            SetColour();
            SetOpacity();

        }

        static CCLabelTTF CreateLabel()
        {
            return new CCLabelTTF("Hello Cocos2D-XNA", "MarkerFelt", 22)
            {
                Position = CCDirector.SharedDirector.WinSize.Center
            };
        }

        void SetColour()
        {
            Color = new CCColor3B(Microsoft.Xna.Framework.Color.Blue);
        }

        void SetOpacity()
        {
            Opacity = 255;
        }
    }
}

