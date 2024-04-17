namespace GeoAppLibrary

using GeoAppLibrary.Interface;

public class Square : IShape
{
    private double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public double CalculateArea()
    {
        return sideLength * sideLength;
    }

    public double CalculatePerimeter()
    {
        return 4 * sideLength;
    }
}