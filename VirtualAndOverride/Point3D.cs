public class Point3D : Point
{
    public int z { get; }

    public Point3D(int x, int y, int z) : base(x, y)
    {
        this.z = z;
    }

    override public string getPoint()
    {
        return base.getPoint() + ", " + this.z;
    }
}