// See https://aka.ms/new-console-template for more information

int length, width, height;

try
{
    Console.WriteLine("Enter Length:");
    length = Convert.ToInt32(Console.ReadLine());
}
catch (System.FormatException)
{
    Console.WriteLine("Your entry was not a valid numerical input. Try again.");
    Console.WriteLine("Enter Length:");
    length = Convert.ToInt32(Console.ReadLine());
}
catch (System.OverflowException)
{
    Console.WriteLine("Your entry was too large of a number. Try again.");
    Console.WriteLine("Enter Length:");
    length = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine("Enter Width:");
width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Height:");
height = Convert.ToInt32(Console.ReadLine());

Cube cube = new Cube(width, height, length);
var triangle = new Triangle(length, height, 27);
var rectangle = new Rectangle(length, height);

Console.WriteLine("Cube area is: " + cube.getArea());
Console.WriteLine("Cube volume is: " + cube.getVolume());

Console.WriteLine("Triangle area is: " + triangle.getArea());

Console.WriteLine("Rectangle area is: " + rectangle.getArea());