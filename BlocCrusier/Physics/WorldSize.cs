namespace BlocCrusier.Physics
{
    public struct WorldSize
    {
        MetresVector worldSize;

        public MetresVector TopLeft
        {
            get { return worldSize.WithX(-4); }
        }

        public MetresVector TopRight
        {
            get { return worldSize; }
        }

        public MetresVector BottomLeft
        {
            get { return MetresVector.Zero.WithX(-4); }
        }

        public MetresVector BottomRight
        {
            get { return worldSize.WithZeroY(); }
        }

        public WorldSize(PointsSize screenSize)
        {
            worldSize = (screenSize * 4).ToMetres();
        }
    }
}