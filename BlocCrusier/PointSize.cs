using BlocCrusier.Physics;
using Box2D.Common;
using Cocos2D;

namespace BlocCrusier
{
    public struct PointSize
    {
        readonly CCSize value;

        public PointSize(float width, float height) : this(new CCSize(width, height))
        {
        }

        PointSize(CCSize value)
        {
            this.value = value;
        }

        public static implicit operator PointSize(CCSize from)
        {
            return new PointSize(from);
        }

        public static PointSize operator *(PointSize toMultiply, int multiplier)
        {
            return new PointSize(toMultiply.value * multiplier);
        }

        public static implicit operator CCSize(PointSize from)
        {
            return from.value;
        }

        public PointVector ToVector()
        {
            return new PointVector(value.Width, value.Height);
        }

        public MetreSize ToMetres()
        {
            CCSize metreSize = value * MetreVector.PointsToMetresRatio;
            return new MetreSize(metreSize.Width, metreSize.Height);
        }
    }
}