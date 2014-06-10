using BlocCrusier.Physics;
using Cocos2D;

namespace BlocCrusier
{
    public struct PointSize
    {
        readonly CCSize size;

        public PointSize(float width, float height) : this(new CCSize(width, height))
        {
        }

        PointSize(CCSize size)
        {
            this.size = size;
        }

        public static implicit operator PointSize(CCSize from)
        {
            return new PointSize(from);
        }

        public static PointSize operator *(PointSize toMultiply, int multiplier)
        {
            return new PointSize(toMultiply.size * multiplier);
        }

        public static implicit operator CCSize(PointSize from)
        {
            return from.size;
        }

        public MetreVector ToMetres()
        {
            CCSize metresSize = size * MetreVector.PointsToMetresRatio;
            return new MetreVector(metresSize.Width, metresSize.Height);
        }
    }
}