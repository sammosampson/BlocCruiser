using BlocCrusier.Entities;
using Box2D.Dynamics;
using Cocos2D;

namespace BlocCrusier.Physics
{
    public class DynamicBody<TEntityIdentifier> : CCNode, Entity<TEntityIdentifier>
        where TEntityIdentifier : IEntityIdentifier
    {
        readonly TEntityIdentifier identifier;
        readonly b2Body body;

        public DynamicBody(
            TEntityIdentifier identifier, 
            MetreVector position, 
            MetreSize size,
            Density density)
        {
            this.identifier = identifier;

            body = PhysicsWorld.SharedPhysicsWorld.CreateDynamicBody(identifier, position);
            body.AttachBoxFixture(size, density);
        }

        public TEntityIdentifier GetIdentifier()
        {
            return identifier;
        }
    }
}