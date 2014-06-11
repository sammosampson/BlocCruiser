namespace BlocCrusier.Physics
{
    public struct WorldSize
    {
        MetreSize worldSize;

        public MetreVector TopLeft
        {
            get { return worldSize.ToVector().WithX(-4); }
        }

        public MetreVector TopRight
        {
            get { return worldSize.ToVector(); }
        }

        public MetreVector BottomLeft
        {
            get { return MetreVector.Zero.WithX(-4); }
        }

        public MetreVector BottomRight
        {
            get { return worldSize.ToVector().WithZeroY(); }
        }

        public WorldSize(PointSize screenSize)
        {
            worldSize = (screenSize * 4).ToMetres();
        }
    }
}