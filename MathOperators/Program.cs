// See https://aka.ms/new-console-template for more information

//basic assignment operator
int num = 5;

//arithmetic operators
int num1 = 36;
int num2 = 12;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

num1 = num1 + 12;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}");

//compound assignment operators

num1 += 4; //num1 = num1 + 4; same as first statement
Console.WriteLine(num1);
num1 -= 4; //num1 = num1 - 4; same as first statement
Console.WriteLine(num1);
num1 *= 4; //num1 = num1 * 4; same as first statement
Console.WriteLine(num1);
num1 /= 4; //num1 = num1 / 4; same as first statement
Console.WriteLine(num1);
num1 %= 4; //num1 = num1 % 4; same as first statement
Console.WriteLine(num1);