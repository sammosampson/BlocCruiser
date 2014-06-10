using SystemDot.Core;

namespace BlocCrusier.Entities
{
    public abstract class EntityIdentifier : Equatable<EntityIdentifier>, IEntityIdentifier
    {
        public abstract string Id { get; }

        public override bool Equals(EntityIdentifier other)
        {
            return other.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}