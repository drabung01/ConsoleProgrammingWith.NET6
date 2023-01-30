internal static class DateUtil
{
    public static int YearofBirth(int age) 
    {
        Console.WriteLine("Have you had your birthday yet this year? (Y/N) ");
        char answer = Convert.ToChar(Console.ReadLine());
        if (answer == 'Y')
        {
            return DateTime.Now.Year - age;
        }
        else
        {
            return DateTime.Now.Year - 1 - age;
        }
    }
    public static int YearofBirth(DateTime dateOfBirth)
    {
        if (dateOfBirth == null) 
        {
            return 0;
        }
        return dateOfBirth.Year;
    }
    public static int Age(DateTime dateOfBirth)
    {
        if (dateOfBirth == null)
        {
            return 0;
        }
        
        Console.WriteLine("Have you had your birthday yet this year? (Y/N) ");
        char answer = Convert.ToChar(Console.ReadLine());
        if (answer == 'Y')
        {
            return DateTime.Now.Year - dateOfBirth.Year;
        }
        else
        {
            return DateTime.Now.Year - 1 - dateOfBirth.Year;
        }
    }
}
