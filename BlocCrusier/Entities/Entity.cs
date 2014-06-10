namespace BlocCrusier.Entities
{
    public interface Entity<out TEntityIdentifier> where TEntityIdentifier : IEntityIdentifier
    {
        TEntityIdentifier GetIdentifier();
    }
}