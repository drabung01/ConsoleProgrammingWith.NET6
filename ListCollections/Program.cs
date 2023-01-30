// See https://aka.ms/new-console-template for more information

//Declare list
List<string> names = new List<string>();
string name = string.Empty;
//add values to list
//names.Add("Dana");

Console.WriteLine("Enter names to add to the list. To end the loop when you are finished, enter -1");
//while (name != "-1")
//while (name.Equals("-1") == false)
while (!name.Equals("-1")){
    Console.WriteLine("Enter Name:");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1")) {
        names.Add(name);
        Console.WriteLine($"{name} was added successfully");
    }
}

//Print values in list
Console.WriteLine("Printing names via for loop");
for (int i = 0; i < names.Count; i++){
    Console.WriteLine(names[i]);
}

Console.WriteLine("Printing names via for each loop");
foreach (string item in names){
    Console.WriteLine(item);
}