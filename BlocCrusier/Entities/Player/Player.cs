using BlocCrusier.Drawing;
using BlocCrusier.Entities.Shapes;
using BlocCrusier.Physics;
using Cocos2D;

namespace BlocCrusier.Entities.Player
{
    public class Player : CCNode, Entity
    {
        public EntityIdentifier Identifier { get; set; }

        public Player()
        {
            Identifier = new PlayerEntityIdentifier();

            var size = new MetreSize(1, 1);
            var position = MetreVector.Zero;
            AddChild(new DynamicBoxBody(Identifier, position, size, Density.HeftyBox));
            AddChild(new BoxShape(Identifier, size.ToPoints(), Colour.Red));
        }
    }
}