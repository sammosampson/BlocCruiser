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
            AddChild(new DynamicBody<PlayerEntityIdentifier>(GetIdentifier()));
            AddChild(new BoxShape<PlayerEntityIdentifier>(GetIdentifier()));
        }

        public PlayerEntityIdentifier GetIdentifier()
        {
            return identifier;
        }
    }
}