// See https://aka.ms/new-console-template for more information

//prototype - defines the function (type, name, and parameters)
//definition - has the code and contains the code block
//function call - makes the function actually run
//DRY - don't repeat yourself
//YAGNI - you aren't going to need it
//void functions - completes a task and moves along

void printName() {
    Console.WriteLine("Dana Rabung");
}

printName();
Console.WriteLine("End of void function");

void addition(int num1, int num2) {
    Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
}

Console.WriteLine("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

addition(num1, num2);
Console.WriteLine("End of void function");

//value returning functions - completes a task and returns a result
int largestNumber(int number1, int number2, int number3) {
    int largest = num1;
    
    if (largest < number2)
    {
        largest = number2;
    }
    
    if (largest < number3) {
        largest = number3;
    }
    
    return largest;
}

Console.WriteLine("Enter number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int result = largestNumber(number1, number2, number3);
Console.WriteLine("The largest number is " + result);