namespace BlocCrusier.Physics
{
    public class Density
    {
        public static Density Infinite
        {
            get { return new Density(0); }
        }

        public static Density HeftyBox
        {
            get { return new Density(1); }
        }

        public static implicit operator int (Density from)
        {
            return from.density;
        }

        readonly int density;

        Density(int density)
        {
            this.density = density;
        }
    }
}