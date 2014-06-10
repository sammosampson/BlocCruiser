using Box2D.Common;

namespace BlocCrusier.Physics
{
    public struct MetreVector
    {
        public const int PointsToMetresRatio = 32;

        readonly b2Vec2 vector;

        public static MetreVector Zero
        {
            get { return new MetreVector(b2Vec2.Zero); }
        }

        public static implicit operator MetreVector(b2Vec2 from)
        {
            return new MetreVector(from);
        }

        public static implicit operator b2Vec2(MetreVector from)
        {
            return from.vector;
        }

        public MetreVector(float x, float y): this(new b2Vec2(x, y))
        {
        }

        MetreVector(b2Vec2 vector)
        {
            this.vector = vector;
        }

        public PointVector ToPoints()
        {
            b2Vec2 pointsVector = vector / PointsToMetresRatio;
            return new PointVector(pointsVector.x, pointsVector.y);
        }

        public MetreVector WithX(float x)
        {
            return new MetreVector(x, vector.y);
        }

        public MetreVector WithZeroY()
        {
            return WithY(0);
        }

        public MetreVector WithY(float y)
        {
            return new MetreVector(vector.x, y);
        }
    }
}