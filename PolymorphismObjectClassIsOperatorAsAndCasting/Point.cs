public class Point
{
    public int x { get; set; }
    public int y { get; set; }

    public Point()
    {
        this.x = 0;
        this.y = 0;
    }

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public string getPoint()
    {
        return this.x + ", " + this.y;
    }
}