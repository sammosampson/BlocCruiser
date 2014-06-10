using Box2D.Dynamics;

namespace BlocCrusier.Physics
{
    public static class b2WorldExtensions
    {
        public static b2Body CreateBodyAtZeroPosition(this b2World world)
        {
            return world.CreateBody(new b2BodyDef { position = MetreVector.Zero });
        }
    }
}