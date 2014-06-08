using Box2D.Collision;
using Box2D.Dynamics;
using Box2D.Dynamics.Contacts;

namespace BlocCrusier.Physics
{
    public class ContactListener : b2ContactListener
    {
        public override void PreSolve(b2Contact contact, b2Manifold oldManifold)
        {
        }

        public override void PostSolve(b2Contact contact, ref b2ContactImpulse impulse)
        {
        }
    }
}