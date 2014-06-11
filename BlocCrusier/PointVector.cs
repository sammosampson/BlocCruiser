using Cocos2D;

namespace BlocCrusier
{
    public struct PointVector
    {
        readonly CCPoint point;

        public static PointVector Zero
        {
            get { return new PointVector(0, 0); }
        }

        public PointVector(float width, float height)
            : this(new CCPoint(width, height))
        {
        }

        PointVector(CCPoint point)
        {
            this.point = point;
        }

        public static implicit operator PointVector(CCPoint from)
        {
            return new PointVector(from);
        }

        public static PointVector operator *(PointVector toMultiply, int multiplier)
        {
            return new PointVector(toMultiply.point * multiplier);
        }

        public static implicit operator CCPoint(PointVector from)
        {
            return from.point;
        }
    }
}