using Box2D.Common;
using Cocos2D;

namespace BlocCrusier.Physics
{
    public class Box2dDebugRenderer : CCBox2dDraw
    {
        public static b2Draw With16PtFont()
        {
            return new Box2dDebugRenderer("fonts/MarkerFelt-16");
        }

        Box2dDebugRenderer(string spriteFontName) : base(spriteFontName)
        {
            AppendFlags(b2DrawFlags.e_shapeBit);
        }
    }
}