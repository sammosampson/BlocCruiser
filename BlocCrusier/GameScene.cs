using BlocCrusier.Physics;
using Cocos2D;

namespace BlocCrusier
{
    public class GameScene : CCScene
    {
        public GameScene()
        {
            AddChild(new GameWorld(GetWorldSize(CCDirector.SharedDirector.WinSize)));
        }

        WorldSize GetWorldSize(PointSize screenSize)
        {
            return new WorldSize(screenSize);
        }
    }
}