namespace BlocCrusier.Physics
{
    public struct WorldSize
    {
        MetreVector worldSize;

        public MetreVector TopLeft
        {
            get { return worldSize.WithX(-4); }
        }

        public MetreVector TopRight
        {
            get { return worldSize; }
        }

        public MetreVector BottomLeft
        {
            get { return MetreVector.Zero.WithX(-4); }
        }

        public MetreVector BottomRight
        {
            get { return worldSize.WithZeroY(); }
        }

        public WorldSize(PointSize screenSize)
        {
            worldSize = (screenSize * 4).ToMetres();
        }
    }
}