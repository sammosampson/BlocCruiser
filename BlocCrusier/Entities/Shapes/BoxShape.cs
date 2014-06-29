using BlocCrusier.Drawing;
using BlocCrusier.Physics;
using Cocos2D;

namespace BlocCrusier.Entities.Shapes
{
    public class BoxShape : CCNode, Entity
    {
        readonly PointVector bottomRight;
        readonly Colour colour;
        
        public EntityIdentifier Identifier { get; set; }

        public BoxShape(EntityIdentifier identifier, PointSize size, Colour colour)
        {
            Identifier = identifier;
            this.colour = colour;
            bottomRight = size.ToVector();

            Position = CCDirector.SharedDirector.WinSize.Center;
        }

        public override void Draw()
        {
            CCDrawingPrimitives.Begin();
            CCDrawingPrimitives.DrawSolidRect(PointVector.Zero, bottomRight, colour);
            CCDrawingPrimitives.End();

            base.Draw();
        }
    }
}