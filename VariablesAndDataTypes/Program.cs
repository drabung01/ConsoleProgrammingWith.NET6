// See https://aka.ms/new-console-template for more information

//Variable Declarations and Types
string fullName = string.Empty;
int age = 0;
double salary = 0.0;
char gender = char.MinValue;
bool working = false;

//prompt user for input
Console.WriteLine("Please Enter Your Name: ");
fullName = Console.ReadLine();

Console.WriteLine("Please Enter Your Age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Your Salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Please Enter Your Gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Are You Working (true of false): ");
working = Convert.ToBoolean(Console.ReadLine());

//Print Information
Console.WriteLine("Your name is: " + fullName); //concatenation
Console.WriteLine("Your age is: {0}", age);
Console.WriteLine($"Your salary is: {salary}"); //interpolation
Console.WriteLine($"Your gender is: {gender}"); //interpolation
Console.WriteLine($"You are employed: {working}"); //interpolation