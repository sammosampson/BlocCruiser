using BlocCrusier.Drawing;
using BlocCrusier.Entities.Shapes;
using BlocCrusier.Physics;
using Cocos2D;

namespace BlocCrusier.Entities.Player
{
    public class Player : CCNode, Entity<PlayerEntityIdentifier>
    {
        readonly PlayerEntityIdentifier identifier;

        public Player()
        {
            identifier = new PlayerEntityIdentifier();
            var size = new MetreSize(1, 1);
            var position = new MetreVector(0, 0);
            AddChild(new DynamicBody<PlayerEntityIdentifier>(GetIdentifier(), position, size, Density.HeftyBox));
            AddChild(new BoxShape<PlayerEntityIdentifier>(GetIdentifier(),size.ToPoints(), Colour.Red));
        }

        public PlayerEntityIdentifier GetIdentifier()
        {
            return identifier;
        }
    }
}