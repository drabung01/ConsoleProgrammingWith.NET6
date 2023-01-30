// See https://aka.ms/new-console-template for more information

//for loop (counter controlled loop)
for (int i = 0; i < 10; i++) {
    Console.WriteLine("I am in a loop");
    Console.WriteLine("Counter value: " + i);
}

Console.WriteLine();
Console.WriteLine("FOR LOOP IS FINISHED");

//while loop (condition controlled loop: pre-check)
int n = 0;
while (n < 5) {
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("You entered " + n);
}

Console.WriteLine();
Console.WriteLine("WHILE LOOP IS FINISHED");

//do...while loop (condition controlled loop: post-check)
do
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("You entered " + n);
} while (n < 5);

//foreach - honorable mention
/*
 * foreach (var item in collection) { 
 * }
 */
