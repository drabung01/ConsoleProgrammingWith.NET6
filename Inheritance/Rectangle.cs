// See https://aka.ms/new-console-template for more information

class Rectangle : Shape, IShape 
{
    public Rectangle(int length, int height)
    {
        Length = length;
        Height = Height;
    }
    public double getArea()
    {
        return Length * Height;
    }
}