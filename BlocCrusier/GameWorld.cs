using BlocCrusier.Drawing;
using BlocCrusier.Entities.Player;
using BlocCrusier.Physics;
using Cocos2D;

namespace BlocCrusier
{
    public class GameWorld : CCNode
    {
        public GameWorld(WorldSize worldSize)
        {
            AddChild(new GameBackground());
            AddChild(new WorldBox(worldSize));
            AddChild(new Player());
        }

        public override void Update(float dt)
        {
            PhysicsWorld.SharedPhysicsWorld.UpdateSimulation(dt);
            base.Update(dt);
        }
    }
}