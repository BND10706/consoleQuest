# consoleQuest

## Step 2 TODO

This step is about learning functions and building the first real flow for our RPG console game.

By the end of this step, the program should:

1. Start in a main menu.
2. Use functions instead of putting everything directly in `Program.cs`.
3. Show how a function can take no input, 2 inputs, and 3 inputs.
4. Ask the player for choices and validate bad input.

## What Is A Function?

A function is a named block of code that does one job.

We use functions so we can:

1. Reuse code.
2. Keep files easier to read.
3. Break big problems into smaller steps.

Think of a function like a tool in a game:

1. You give the tool a name.
2. You can give it information.
3. It does its job and then returns control back to the program.

## Function Syntax

Here are the three kinds of functions we want to learn in this step.

### 1. Function With No Input

This function does not need any extra information.

```csharp
static void ShowMainMenu()
{
  Console.WriteLine("Welcome to consoleQuest");
  Console.WriteLine("1. Start Game");
  Console.WriteLine("2. Instructions");
  Console.WriteLine("3. Quit");
}
```

Use this for things like:

1. Showing the title screen.
2. Printing the main menu.
3. Displaying game instructions.

### 2. Function With 2 Inputs

This function takes 2 pieces of information.

```csharp
static void ShowAttack(string enemyName, int damage)
{
  Console.WriteLine($"You attack the {enemyName} for {damage} damage.");
}
```

Use this for things like:

1. Attacking an enemy.
2. Healing the player.
3. Showing a simple battle message.

### 3. Function With 3 Inputs

This function takes 3 pieces of information.

```csharp
static void GiveReward(string playerName, int goldAmount, int xpAmount)
{
  Console.WriteLine($"{playerName} earns {goldAmount} gold and {xpAmount} XP.");
}
```

Use this for things like:

1. Awarding loot.
2. Giving rewards after a fight.
3. Showing a level-up or quest reward.

## Step 2 Plan

We are going to redo `Program.cs` so it becomes the entry point for the game, and then create a new file for the main menu.

### File 1: `Program.cs`

This file should become very small.

Its job is only to:

1. Create the starting player variables.
2. Call the main menu function.

Do not put the whole game inside `Program.cs` anymore.

### File 2: `MainMenu.cs`

Create a new file for the menu logic.

This file should handle:

1. Showing the menu.
2. Reading the player choice.
3. Checking if the choice is valid.
4. Sending the player to the correct part of the game.

## Main Menu Idea

The menu should feel like the start of an RPG.

For example:

1. Start Adventure
2. View Character
3. Quit

If the player types something wrong, the game should not crash.

Instead, we should tell the player the input was invalid and ask again.

## Validation

Validation means checking player input before using it.

This is important because players will type the wrong thing sometimes.

Examples of validation:

1. Make sure a number is actually a number.
2. Make sure a menu choice is one of the allowed options.
3. Make sure the player does not press enter on an empty name.

Simple validation examples you can think about:

This is kind of like the example you gave me at church today. We can get more complex later with switch statements.
For now we can just do it this way.

```csharp
if (string.IsNullOrWhiteSpace(input))
{
  Console.WriteLine("Please enter something.");
}
```

So make sure for if statements you understand what the below means.
== this means that it matches exactly.
!= this means not equals

&& means and
|| means or

so you can use the options below to say if choice is not 1 and is not 2 and is not 3

```csharp
if (choice != "1" && choice != "2" && choice != "3")
{
  Console.WriteLine("That is not a valid menu choice.");
}
```

My personal preference for doing things that require more than 1 choice however is using a swtich statement.

## Switch Statement

A switch statement is another way to make decisions in code.

It is useful when you want to check one value against a few possible choices, like a menu in an RPG.

Instead of writing a long list of `if` statements, a switch lets you say:

1. If the player picks `1`, do this.
2. If the player picks `2`, do that.
3. If the player picks `3`, do something else.
4. If nothing matches, show an error message.

That makes switch statements a good fit for menus because the player usually has a small set of fixed options.

Here is an example:

```csharp
switch (choice)
{
  case "1":
    Console.WriteLine("You start your adventure.");
    break;
  case "2":
    Console.WriteLine("You view your character.");
    break;
  case "3":
    Console.WriteLine("Goodbye!");
    break;
  default:
    Console.WriteLine("That is not a valid menu choice.");
    break;
}
```
So what this is doing is this.
The case values are all the different "options" basically if they do this, then do that. if they dont do any of those options, then do default.
Its a simple way to validate, and you can do a whole bunch with it.


## What To Build

1. Make a new branch off `main` and call it `step2`.
2. Replace the current starter code in `Program.cs` with a clean entry point.
3. Create a new file called `MainMenu.cs`.
4. Add a no-input function for the menu.
5. Add a 2-input function for a simple RPG action.
6. Add a 3-input function for a reward or loot message.
7. Add basic validation so the menu does not break on bad input.(Hint do this with switch statement)

## File Names

For this step, keep the file names simple:

1. `Program.cs` is the starting point of the program.
2. `MainMenu.cs` holds the menu logic.

## What Is A Namespace?

A namespace is like a label that helps organize code.

It helps C# know what type or function belongs where, especially when a project starts to grow.

Think of it like putting game items into different boxes:

1. One box for menu code.
2. One box for battle code.
3. One box for player code.

Namespaces help keep those boxes organized.

## What Does `using` Do?

`using` tells C# that you want to use code from another namespace.

If two files are in different namespaces, `using` helps `Program.cs` find the code it needs.

For example:

```csharp
using consoleQuest.Game;
```

That line tells C# to look in the `consoleQuest.Game` namespace.

If `MainMenu.cs` is in that namespace, then `Program.cs` can call the menu function without needing to write the full namespace every time.

If the files are in the same namespace, you may not need an extra `using` statement at all.

## Folder Idea

For this step, a good place for the main menu file is:

1. `src/Game/MainMenu.cs`

That keeps the menu code with the rest of the RPG game logic.

## How `Program.cs` Can Access `MainMenu.cs`

`Program.cs` does not need to contain all of the game logic.

It can call a function that lives in `MainMenu.cs`.

That works because both files are part of the same project, so `Program.cs` can use the function name and run the code from the menu file.

In simple terms:

1. `Program.cs` starts the game.
2. `Program.cs` creates the player variables.
3. `Program.cs` calls the menu function from `MainMenu.cs`.
4. `MainMenu.cs` shows the menu and handles the choices.

Here is a simple example of what that call can look like:

```csharp
string playerName = "Randy";
int health = 10;
int gold = 0;

MainMenu.ShowMainMenu(playerName, health, gold);
```

This means `Program.cs` is handing the player data to the menu function so the menu can use it.

That is not the same thing as player input.

`playerName`, `health`, and `gold` are values that `Program.cs` sends into the function. Those are called function inputs or parameters.

If we want the player to type something, that happens inside the menu function with `Console.ReadLine()`.

For example:

```csharp
Console.WriteLine("Choose an option:");
string choice = Console.ReadLine();
```

So the flow is:

1. `Program.cs` starts the game.
2. `Program.cs` calls `MainMenu.ShowMainMenu(...)`.
3. `MainMenu.cs` shows the menu.
4. `MainMenu.cs` uses `Console.ReadLine()` to get the player's choice.

## Suggested RPG Flow

You can use this idea for the game:

1. The player sees the main menu.
2. The player starts the adventure.
3. The game shows a small battle or reward message.
4. The player returns to the menu or quits.

## What `Program.cs` Should Do

At the start of the app, `Program.cs` should:

1. Set up the player name.
2. Set up health and gold.
3. Call the main menu function.

That is it.

The goal is to move the game logic into functions so the project starts to feel like a real game instead of one long script.

## Finish Line

When this step is done, the app should be ready for Step 3, where we can start building more game logic on top of the menu and functions.
