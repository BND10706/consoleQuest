Console.WriteLine("Welcome to consoleQuest");
Console.WriteLine("In this app you will pick two numbers and I will add them together");
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Hello {name}, What would you like your first number to be?");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine($"{num1} is a good first number. What would you like your second number to be?");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"Great! I will now add {num1} to {num2}");
int total_num = num1 + num2;
Console.WriteLine($"The answer is {total_num}.");
Console.WriteLine("Type help, add, or quit");


// string stores text.
string playerName = "Randy";

// int stores whole numbers.
int health = 10;
int gold = 0;
int stamina = 100;

// Console.WriteLine sends text to the console.
Console.WriteLine("Welcome to consoleQuest");
// The $ means string interpolation, so you can put variables inside the text.
// The {} parts are where the variables go.
Console.WriteLine($"Player: {playerName}");
Console.WriteLine($"Health: {health}");
Console.WriteLine($"Gold: {gold}");
Console.WriteLine($"Stamina: {stamina}");
Console.WriteLine("Type help, add, or quit");
Console.WriteLine("2 + 2 = " + (2 + 2));
Console.WriteLine("Would you like to sell your hat for 2 gold pieces? Type 'y' for yes or 'n' for no. ");
string Hat = Console.ReadLine();
if (Hat.ToUpper() == "Y")
{
    Console.WriteLine("You now have " + (0 + 2) + " gold pieces!");
    gold = +2;
}
else
{
    Console.WriteLine("No problem, I hope you have a nice day!");
}
Console.WriteLine($"Health: {health}");
Console.WriteLine($"Gold: {gold}");
Console.WriteLine($"Stamina: {stamina}");