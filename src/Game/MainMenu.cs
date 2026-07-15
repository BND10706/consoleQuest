namespace consoleQuest.Game;

public static class MainMenu
{
    public static void ShowMainMenu(string playerName, string city, int health, int gold, int xpAmount, int poisonHurt)
    {
        Console.WriteLine("Welcome to Console Quest");
        Console.WriteLine("1. Start Game");
        Console.WriteLine("2. View Party Members");
        Console.WriteLine("3. Quit");
        Console.WriteLine("Choose an option:");
        string choice = Console.ReadLine();
    
        switch (choice)
        {
            case "1":
                Console.WriteLine("You start your adventure.");
                break;
            case "2":
                Console.WriteLine("You view the members of your party.");
                break;
            case "3":
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("That is not a valid menu choice.");
                break;
        }
        static void ShowAttack(string playerName, int poisonHurt)
        {
            Console.WriteLine($"{playerName} eats a poison berry and loses {poisonHurt} of health");
        }
        static void GiveReward(string cityName, int gold, int xpAmount)
        {
            Console.WriteLine($"You attack the {cityName} and collect {gold} gold pieces and earn {xpAmount} XP.");
        }
    }
}