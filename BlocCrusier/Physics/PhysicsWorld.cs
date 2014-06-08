using SystemDot.Core;
using Box2D.Dynamics;
using Cocos2D;

namespace BlocCrusier.Physics
{
    public class PhysicsWorld : b2World
    {
        public static PhysicsWorld SharedPhysicsWorld { get; private set; }

        static PhysicsWorld()
        {
            SharedPhysicsWorld = new PhysicsWorld();
        }

        PhysicsWorld() : base(Physics.Gravity.Earth)
        {
            AllowSleep = false;
            SetContinuousPhysics(true);
            SetDebugDraw(Box2dDebugRenderer.With16PtFont());
            SetContactListener(new ContactListener());
        }

        public void UpdateSimulation(float deltaTime)
        {
            SingleStepSimulation(deltaTime);
            NotifyMovementOfPhysicsBodies();
        }

        void SingleStepSimulation(float deltaTime)
        {
            Step(
                deltaTime, 
                SimulationIterations.Velocity, 
                SimulationIterations.Position);
        }

        void NotifyMovementOfPhysicsBodies()
        {
            for (b2Body body = BodyList; body != null; body = body.Next)
            {
                if (body.UserData == null) continue;
                NotifyMovementOfPhysicsBody(body);
            }
        }

        static void NotifyMovementOfPhysicsBody(b2Body body)
        {
            GameMessenger.Send<PhysicsBodyMoved>(
                body.UserData.As<EntityIdentifier>(),
                message =>
                {
                    message.Position = body.Position;
                    message.Rotation = body.Angle;
                });
        }

        static class SimulationIterations
        {
            public const int Velocity = 8;
            public const int Position = 1;
        }
    }
}