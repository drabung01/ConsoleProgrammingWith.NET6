// See https://aka.ms/new-console-template for more information

//if statements (==, <, >, <=, >=, !=)
Console.WriteLine("Enter number of apples: ");
int numberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int numberOfOranges = Convert.ToInt32(Console.ReadLine());

if (numberOfApples > numberOfOranges) {
    Console.WriteLine("You have more apples");
} else if (numberOfApples < numberOfOranges) {
    Console.WriteLine("You have more oranges");
} else if (numberOfOranges == numberOfApples) {
    Console.WriteLine("You have the same number of apples and oranges");
}

//switch statements
Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

switch (grade) {
    case int n when (n >= 0 && n < 60):
        Console.WriteLine("You Failed");
        break;
    case int n when n >= 60 && n <= 100:
        Console.WriteLine("You Passed");
        break;
    case 101:
        Console.WriteLine("Single Case Example");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}

//ternary operator
var message = numberOfApples > numberOfOranges ? "You have more Apples" : "You have more Oranges";
Console.WriteLine(message);