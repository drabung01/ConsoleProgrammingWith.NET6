// See https://aka.ms/new-console-template for more information

using System.Globalization;

//empty DateTime
DateTime date = new DateTime();

//create a DateTime from date and time
DateTime dateOfBirth = new DateTime(2003, 03, 10);
Console.WriteLine("My DOB is: " + dateOfBirth);

//create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The time now is: " + now);

//create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/23/2023", CultureInfo.InvariantCulture);
Console.WriteLine("The Date from stirng is: " + dateFromString);

//add additional time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

//ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

//Date only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date only: " + dateOnlyOfBirth);

//Time only
TimeOnly timeOnly = TimeOnly.FromDateTime(now);
Console.WriteLine("Time only: " + timeOnly);

Console.WriteLine("Day of week: " + dateOfBirth.DayOfWeek);
Console.WriteLine("Day of year: " + dateOfBirth.DayOfYear);
Console.WriteLine("Time of Day: " + dateOfBirth.TimeOfDay);
Console.WriteLine("Ticks: " + dateOfBirth.Ticks);
Console.WriteLine("Kind: " + dateOfBirth.Kind);
