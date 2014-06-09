using BlocCrusier.Drawing;
using BlocCrusier.Physics;
using Cocos2D;

namespace BlocCrusier
{
    public class Player : CCNode, Entity<PlayerEntityIdentifier>
    {
        public Player()
        {
            AddChild(new DynamicBody<PlayerEntityIdentifier>(GetIdentifier()));
            Position = CCDirector.SharedDirector.WinSize.Center;
        }

        public override void Draw()
        {
            CCDrawingPrimitives.Begin();
            CCDrawingPrimitives.DrawSolidRect(CCPoint.Zero, new CCPoint(-100, -100), Colour.Red);
            CCDrawingPrimitives.End();
            base.Draw();
        }

        public PlayerEntityIdentifier GetIdentifier()
        {
            throw new System.NotImplementedException();
        }
    }

    public class DynamicBody<TEntityIdentifier> : CCNode, Entity<EntityIdentifier>
        where TEntityIdentifier : EntityIdentifier
    {
        readonly TEntityIdentifier identifier;

        public DynamicBody(TEntityIdentifier identifier)
        {
            this.identifier = identifier;
            GameMessenger.RegisterHandler<PhysicsBodyMoved>(GetIdentifier(), OnPhysicsBodyMoved);
        }

        void OnPhysicsBodyMoved(PhysicsBodyMoved @event)
        {
            
        }

        public EntityIdentifier GetIdentifier()
        {
            return identifier;
        }
    }

    public struct PlayerEntityIdentifier : EntityIdentifier
    {
    }

    public interface Entity<out TEntityIdentifier> 
        where TEntityIdentifier : EntityIdentifier
    {
        TEntityIdentifier GetIdentifier();
    }
}