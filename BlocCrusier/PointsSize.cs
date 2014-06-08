using BlocCrusier.Physics;
using Cocos2D;

namespace BlocCrusier
{
    public struct PointsSize
    {
        readonly CCSize size;

        public PointsSize(float width, float height) : this(new CCSize(width, height))
        {
        }

        PointsSize(CCSize size)
        {
            this.size = size;
        }

        public static implicit operator PointsSize(CCSize from)
        {
            return new PointsSize(from);
        }

        public static PointsSize operator *(PointsSize toMultiply, int multiplier)
        {
            return new PointsSize(toMultiply.size * multiplier);
        }

        public static implicit operator CCSize(PointsSize from)
        {
            return from.size;
        }

        public MetresVector ToMetres()
        {
            CCSize metresSize = size * MetresVector.PointsToMetresRatio;
            return new MetresVector(metresSize.Width, metresSize.Height);
        }
    }
}