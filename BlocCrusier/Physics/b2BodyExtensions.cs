using BlocCrusier.ObjectPooling;
using Box2D.Collision.Shapes;
using Box2D.Dynamics;

namespace BlocCrusier.Physics
{
    public static class b2BodyExtensions
    {
        public static void AttachBoxFixture(this b2Body body, MetresVector @from, MetresVector to, Density density)
        {
            var boxShape = ObjectPool.Get<b2EdgeShape>();
            boxShape.Set(@from, to);
            body.CreateFixture(boxShape, density);
            ObjectPool.Return(boxShape);
        }
    }
}