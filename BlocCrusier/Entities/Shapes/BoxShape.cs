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
        readonly Colour colour;

        public BoxShape(TEntityIdentifier identifier, PointSize size, Colour colour)
        {
            this.identifier = identifier;
            this.colour = colour;
            bottomRight = size.ToVector();

            Position = CCDirector.SharedDirector.WinSize.Center;
            
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
            CCDrawingPrimitives.DrawSolidRect(PointVector.Zero, bottomRight, colour);
            CCDrawingPrimitives.End();

            base.Draw();
        }

        public TEntityIdentifier GetIdentifier()
        {
            return identifier;
        }
    }
}