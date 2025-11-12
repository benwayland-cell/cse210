

class Program
{
    static void Main()
    {
        Circle myCircle = new Circle(10);
        Console.WriteLine(myCircle.GetCircleArea());
        myCircle.SetRadius(20);
        Console.WriteLine(myCircle.GetRadius());
        Console.WriteLine(myCircle.GetCircumference());
        Console.WriteLine(myCircle.GetDiameter());
    }
}