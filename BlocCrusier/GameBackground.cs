using BlocCrusier.Drawing;
using Cocos2D;

namespace BlocCrusier
{
    public class GameBackground : CCLayerColor
    {
        public GameBackground()
        {
            SetColour();
            SetOpacity();

        }

        void SetColour()
        {
            Color = Colour.Blue;
        }

        void SetOpacity()
        {
            Opacity = Drawing.Opacity.FullyOpaque;
        }
    }
}

