using Box2D.Dynamics;
using Cocos2D;

namespace BlocCrusier.Physics
{
    public class WorldBox : CCNode
    {
        public WorldBox(WorldSize worldSize)
        {
            b2Body groundBody = PhysicsWorld.SharedPhysicsWorld.CreateBodyAtZeroPosition();
            groundBody.AttachBoxFixture(worldSize.BottomLeft, worldSize.BottomRight, Density.Infinite);
            groundBody.AttachBoxFixture(worldSize.TopLeft, worldSize.TopRight, Density.Infinite);
            groundBody.AttachBoxFixture(worldSize.TopLeft, worldSize.BottomLeft, Density.Infinite);
            groundBody.AttachBoxFixture(worldSize.TopRight, worldSize.BottomRight, Density.Infinite);
        }
    }
}