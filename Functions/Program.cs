
Console.WriteLine("Are you coming or leavning? (in/out):");
string userChoice = Console.ReadLine();

if (userChoice == "in")
{
    PrintHello();
}
else if(userChoice == "out")
{
    PrintGoodBye();
}

static void PrintHello() //function / method
{
    Console.WriteLine("Hello world!");
}

static void PrintGoodBye()
{
    Console.WriteLine("See you later, alligator.");
}
