using Box2D.Common;

namespace BlocCrusier.Physics
{
    public struct MetreSize
    {
        readonly b2Vec2 value;

        public MetreSize(float width, float height) : this(new b2Vec2(width, height))
        {
        }

        MetreSize(b2Vec2 value)
        {
            this.value = value;
        }

        public MetreVector ToVector()
        {
            return new MetreVector(value);
        }

        public PointSize ToPoints()
        {
            b2Vec2 pointsSize = value / MetreVector.PointsToMetresRatio;
            return new PointSize(pointsSize.x, pointsSize.y);
        }
    }
}