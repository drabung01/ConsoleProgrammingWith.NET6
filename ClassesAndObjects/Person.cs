// See https://aka.ms/new-console-template for more information

//primitive datatypes
//int, string, char, bool

//object oriented programming - creating your own datatype
//class - blueprint
//single responsibility principle - only one purpose or class per file

class Person
{
    //Properties when public
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    
    //Fields when private
    private double _salary { get; set; }

    public void setSalary(double salary) 
    {
        _salary = salary;
    }

    public double getSalary() 
    {
        return _salary;
    }

    public string getFullName() 
    {
        return FirstName + " " + LastName;
    }
    public string getFullName(string middleName)
    {
        return FirstName + " " + middleName + " " + LastName;
    }

    public int getYearOfBirth() 
    {
        Console.WriteLine("Have you had your birthday yet this year? (Y/N) ");
        char answer = Convert.ToChar(Console.ReadLine());
        if (answer == 'Y')
        {
            return DateTime.Now.Year - Age;
        }
        else 
        {
            return DateTime.Now.Year - 1 - Age;
        }
        
    }
}