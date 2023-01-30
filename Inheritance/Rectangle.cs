// See https://aka.ms/new-console-template for more information

class Rectangle : Shape, IShape 
{
    public double getArea()
    {
        return Length * Height;
    }
}