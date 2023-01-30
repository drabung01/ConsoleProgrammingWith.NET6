// See https://aka.ms/new-console-template for more information
string firstName = "Dana";
string lastName = "Rabung";
DateTime date = DateTime.Now;

//print to screen
Console.WriteLine(firstName);
Console.WriteLine("String being printed");

//concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine("My full name is " + lastName + ", " + firstName);
Console.WriteLine($"My full name is {lastName}, {firstName}");
Console.WriteLine("My full name is {0}, {1}", lastName, firstName);

//string length
int length = firstName.Length;
Console.WriteLine($"Your name is {length} letters long");

//replace string parts
string newName = firstName.Replace('D', 'S');
Console.WriteLine($"Your new name is {newName}");

string newName1 = firstName.Replace('n', 'r');
Console.WriteLine($"Your new name is {newName1}");

//append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullName}");

//split string
string[] splitName = fullName.Split(' ');
for (int i = 0; i < splitName.Length; i++) {
    Console.WriteLine(splitName[i]);
}

//compare strings
string nullString = null;
string emptyString = ""; //string.Empty
string whitespaceString = " ";

if (string.IsNullOrEmpty(nullString)) {
    Console.WriteLine("String is null");
}

if (firstName == lastName) {
    Console.WriteLine("Names are equal");
}

if (firstName != lastName){
    Console.WriteLine("Names are not equal");
}

int comparisonResult = string.Compare(firstName, lastName);

if (comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else {
    Console.WriteLine("Names are not equal");
}
//convert to string
string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();
convertedString = 1567149892.ToString();

//toUpper and toLower converts case like in Java