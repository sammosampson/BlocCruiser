using BlocCrusier.Entities;
using Box2D.Dynamics;
using Cocos2D;

namespace BlocCrusier.Physics
{
    public class DynamicBody<TEntityIdentifier> : CCNode, Entity<TEntityIdentifier>
        where TEntityIdentifier : IEntityIdentifier
    {
        readonly TEntityIdentifier identifier;

        public DynamicBody(TEntityIdentifier identifier)
        {
            this.identifier = identifier;
            b2Body body = PhysicsWorld.SharedPhysicsWorld.CreateBody(
                new b2BodyDef
                {
                    type = b2BodyType.b2_dynamicBody
                });
            body.AttachBoxFixture();
            
        }

        public TEntityIdentifier GetIdentifier()
        {
            return identifier;
        }
    }
}