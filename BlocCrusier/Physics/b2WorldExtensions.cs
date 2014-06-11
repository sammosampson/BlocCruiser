using BlocCrusier.Entities;
using Box2D.Dynamics;

namespace BlocCrusier.Physics
{
    public static class b2WorldExtensions
    {
        public static b2Body CreateBodyAtZeroPosition(this b2World world)
        {
            return world.CreateBody(new b2BodyDef { position = MetreVector.Zero });
        }

        public static b2Body CreateDynamicBody(this b2World world, IEntityIdentifier identifier, MetreVector position)
        {
            return world.CreateBody(new b2BodyDef
            {
                type = b2BodyType.b2_dynamicBody,
                position = position,
                userData = identifier
            });
        }
    }
}