// See https://aka.ms/new-console-template for more information

//Declare Fixed Size Array
int[] grades = new int[5];  //5 address spaces - 0, 1, 2, 3, 4

//Add values to Fixed Size Array
//grades[0] = 1;
//grades[1] = 25;
//grades[2] = 38;  Not efficient... better shown below
//grades[3] = 45;
//grades[4] = 54;
//grades[5] = 60;   unhandled exception if you do this

//grades = new int[] { 1, 25, 38, 45, 54 };
//good but still might not know grades before hand so below is best

Console.WriteLine("Enter All Grades");
for (int i = 0; i < grades.Length; i++){
    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

//Print values in Fixed Size Array
Console.WriteLine("The grades you have entered are: ");
for (int i = 0; i < grades.Length; i++){
    Console.WriteLine(grades[i]);
}

//Declare variable sized array
string[] studentNames = new string[] {"Test", "Student1", "etc..."};

//add values to variabe sized array
Console.WriteLine("Enter All Names");
for (int i = 0; i < studentNames.Length; i++){
    Console.Write("Enter Name: ");
    studentNames[i] = Console.ReadLine();
}

//print values in variabe sized array
Console.WriteLine("The names you have entered are: ");
for (int i = 0; i < studentNames.Length; i++){
    Console.WriteLine(studentNames[i]);
}