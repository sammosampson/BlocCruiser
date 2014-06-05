using Cocos2D;

namespace BlocCrusier
{
    public class GameBackgroundLayerColour : CCLayerColor
    {
        public GameBackgroundLayerColour()
        {
            AddChild(CreateBackgroundBlock());
            SetColour();
            SetOpacity();

        }

        static GameBackgroundBlock CreateBackgroundBlock()
        {
            return new GameBackgroundBlock
            {
                Position = CCDirector.SharedDirector.WinSize.Center
            };
        }

        void SetColour()
        {
            Color = Colour.Blue;
        }

        void SetOpacity()
        {
            Opacity = BlocCrusier.Opacity.FullyOpaque;
        }
    }

    public class Opacity
    {
        public static byte FullyOpaque
        {
            get { return 255; }
        }
    }

    public class Colour
    {
        public static CCColor3B Blue
        {
            get { return new CCColor3B(Microsoft.Xna.Framework.Color.Blue); }
        }
        
        public static CCColor3B Red
        {
            get { return new CCColor3B(Microsoft.Xna.Framework.Color.Red); }
        }
    }

    public class GameBackgroundBlock : CCNode
    {
        public override void Draw()
        {
            base.Draw();
            CCDrawingPrimitives.DrawSolidRect(Position, Position, Colour.Red);
        }
    }
}

