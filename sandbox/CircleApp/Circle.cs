class Circle
{
    private double _radius;

    private const double _pi = 3.145;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetCircleArea()
    {
        return _pi * _radius * _radius;
    }
}