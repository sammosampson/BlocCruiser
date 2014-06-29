using BlocCrusier.Drawing;
using BlocCrusier.Entities.Player;
using Cocos2D;

namespace BlocCrusier
{
    public class GameBackground : CCLayerColor
    {
        public GameBackground()
        {
            SetColour();
            SetOpacity();
            AddChild(new Player());
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

