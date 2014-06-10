using BlocCrusier.Drawing;
using BlocCrusier.Physics;
using Cocos2D;

namespace BlocCrusier.Entities.Shapes
{
    public class BoxShape<TEntityIdentifier> : CCNode, Entity<TEntityIdentifier>
        where TEntityIdentifier : IEntityIdentifier
    {
        readonly TEntityIdentifier identifier;
        readonly PointVector bottomRight;
        readonly CCPoint topLeft;

        public BoxShape(TEntityIdentifier identifier)
        {
            this.identifier = identifier;

            Position = CCDirector.SharedDirector.WinSize.Center;
            
            topLeft = CCPoint.Zero;
            bottomRight = new PointVector(-100, -100);
            
            GameMessenger.RegisterHandler<PhysicsBodyMoved>(
                GetIdentifier(), 
                OnPhysicsBodyMoved);
        }

        void OnPhysicsBodyMoved(PhysicsBodyMoved @event)
        {
            Position = @event.Position.ToPoints();
            Rotation = @event.Rotation.ToDegrees();
        }

        public override void Draw()
        {
            CCDrawingPrimitives.Begin();
            CCDrawingPrimitives.DrawSolidRect(topLeft, bottomRight, Colour.Red);
            CCDrawingPrimitives.End();
            base.Draw();
        }

        public TEntityIdentifier GetIdentifier()
        {
            return identifier;
        }
    }
}