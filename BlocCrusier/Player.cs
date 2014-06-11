using BlocCrusier.Drawing;
using Cocos2D;

namespace BlocCrusier
{
    public class Player : Entity<PlayerEntityIdentifier>
    {
        public Player()
        {
            Position = CCDirector.SharedDirector.WinSize.Center;
        }

        public override void Draw()
        {
            CCDrawingPrimitives.Begin();
            CCDrawingPrimitives.DrawSolidRect(CCPoint.Zero, new CCPoint(-100, -100), Colour.Red);
            CCDrawingPrimitives.End();
            base.Draw();
        }
    }

    public abstract class Entity<TEntityIdentifier> : CCNode
        where TEntityIdentifier : EntityIdentifier
    {
        protected void AddChildEntity(Entity<TEntityIdentifier> entity)
        {
            RunAction(new CCBlink(20f, 122));
        }
    }

    public struct PlayerEntityIdentifier : EntityIdentifier
    {
    }
}