using Box2D.Common;

namespace BlocCrusier.Physics
{
    public struct MetresVector
    {
        public const int PointsToMetresRatio = 32;

        readonly b2Vec2 vector;

        public static MetresVector Zero
        {
            get { return new MetresVector(b2Vec2.Zero); }
        }

        public static implicit operator MetresVector(b2Vec2 from)
        {
            return new MetresVector(from);
        }

        public static implicit operator b2Vec2(MetresVector from)
        {
            return from.vector;
        }

        public MetresVector(float x, float y): this(new b2Vec2(x, y))
        {
        }

        MetresVector(b2Vec2 vector)
        {
            this.vector = vector;
        }

        public PointsSize ToPoints()
        {
            b2Vec2 pointsVector = vector / PointsToMetresRatio;
            return new PointsSize(pointsVector.x, pointsVector.y);
        }

        public MetresVector WithX(float x)
        {
            return new MetresVector(x, vector.y);
        }

        public MetresVector WithZeroY()
        {
            return WithY(0);
        }

        public MetresVector WithY(float y)
        {
            return new MetresVector(vector.x, y);
        }
    }
}