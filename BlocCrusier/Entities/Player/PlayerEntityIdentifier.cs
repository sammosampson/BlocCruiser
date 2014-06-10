namespace BlocCrusier.Entities.Player
{
    public class PlayerEntityIdentifier : EntityIdentifier
    {
        const string PlayerId = "Player";
        
        public override string Id
        {
            get { return PlayerId; }
        }
    }
}