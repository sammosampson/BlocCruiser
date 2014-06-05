using Cocos2D;

namespace BlocCrusier
{
    public class GameScene : CCScene
    {
        public GameScene()
        {
            AddChild(new GameBackgroundLayerColour());
        }
    }
}