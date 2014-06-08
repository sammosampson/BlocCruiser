using Cocos2D;

namespace BlocCrusier.Physics
{
    public struct Radians
    {
        readonly float angle;

        Radians(float angle)
        {
            this.angle = angle;
        }

        public static implicit operator Radians(float angle)
        {
            return new Radians(angle);
        }

        public float ToDegrees()
        {
            return -1*CCMacros.CCRadiansToDegrees(angle);
        }
    }
}