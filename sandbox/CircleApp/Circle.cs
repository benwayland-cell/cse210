class Circle
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetCircleArea()
    {
        return Math.PI * _radius * _radius;
    }

    public double GetCircumference()
    {
        return Math.PI * 2 * _radius;
    }

    public double GetDiameter()
    {
        return 2 * _radius;
    }
}