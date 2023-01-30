// See https://aka.ms/new-console-template for more information

//primitive datatypes
//int, string, char, bool

//object oriented programming - creating your own datatype
//class - blueprint

//single responsibility principle - only one purpose or class per file

Person person = new Person(); //don't really need the second Person but can include it
Person person2 = new (); //see? This still works

Console.WriteLine("Enter First Name: ");
person.FirstName = Console.ReadLine();

Console.WriteLine("Enter Last Name: ");
person.LastName = Console.ReadLine();

Console.WriteLine("Enter Age: ");
person.Age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter Salary: ");
double salary = Convert.ToDouble(Console.ReadLine());

person.setSalary(salary);

Console.WriteLine("Enter Middle Name: ");
string middleName = Console.ReadLine();

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full name is " + person.getFullName());
}
else 
{
    Console.WriteLine("Full name is " + person.getFullName(middleName));
}

Console.WriteLine("Age is " + person.Age); 
Console.WriteLine("Salary is " + person.getSalary());
Console.WriteLine("Year of birth is: " + person.getYearOfBirth());

Console.WriteLine("Date of birth from other class' method is " + DateUtil.YearofBirth(person.Age));