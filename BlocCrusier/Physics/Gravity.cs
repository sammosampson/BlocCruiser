using Box2D.Common;

namespace BlocCrusier.Physics
{
    public class Gravity
    {
        public static Gravity Earth
        {
            get { return new Gravity(0.0f, -9.81f); }
        }

        public static implicit operator b2Vec2(Gravity from)
        {
            return from.value;
        }

        readonly b2Vec2 value;

        Gravity(float x, float y)
        {
            value = new b2Vec2(x, y);
        }
    }
}