using BlocCrusier.Entities;
using Box2D.Dynamics;
using Cocos2D;

namespace BlocCrusier.Physics
{
    public class DynamicBoxBody : CCNode, Entity
    {
        readonly b2Body body;

        public EntityIdentifier Identifier { get; set; }

        public DynamicBoxBody(
            EntityIdentifier identifier,
            MetreVector position, 
            MetreSize size,
            Density density)
        {
            Identifier = identifier;
            body = PhysicsWorld.SharedPhysicsWorld.CreateDynamicBody(Identifier, position);
            body.AttachBoxFixture(size, density);
        }
    }
}