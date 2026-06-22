# consoleQuest

## Step 1 TODO

1. Clone the repo in GitHub Desktop.
2. Start with a simple folder structure.

```text
consoleQuest/
  src/
    Program.cs
    Game/
    Commands/
    Models/
```

3. Add a `.gitignore` file before you commit.
4. `.gitignore` tells Git what to leave out, like build files, temp files etc
5. For a C# app, a simple `.gitignore` should ignore things like `bin/`, `obj/`, and `.vs/`.

```gitignore
bin/
obj/
.vs/
```

6. Create a branch before changing anything.
7. Use this branch naming format: `users/Randy/<branch-name>`.
8. Example branch name: `users/Randy/Step1`.
9. Build a very basic C# console app that prints instructions, reads input, stores variables, adds numbers, and responds to commands like `help`, `add`, and `quit`.(These commands wont work just yet).
10. Put this starter code in `src/Program.cs`.

```csharp
// Program.cs is the main file the app starts from.

// string stores text.
string playerName = "Randy";

// int stores whole numbers.
int health = 10;
int gold = 0;

// Console.WriteLine sends text to the console.
Console.WriteLine("Welcome to consoleQuest");
// The $ means string interpolation, so you can put variables inside the text.
// The {} parts are where the variables go.
Console.WriteLine($"Player: {playerName}");
Console.WriteLine($"Health: {health}");
Console.WriteLine($"Gold: {gold}");
Console.WriteLine("Type help, add, or quit");
Console.WriteLine("2 + 2 = " + (2 + 2));
```

11. Challenge for you: add one more variable for the player, print it, and add a second challenge that uses math to add more gold, then print the new gold total.
12. Another challenge I would like to add is play around with this opening program some just using `Console.WriteLine()`.
13. `Program.cs` is the entrance of the app. Right now it starts here, but we will expand it later.
14. Commit your work in GitHub Desktop, publish the branch, then open a Pull Request from GitHub Desktop.
15. When finished, push your branch and open a PR into `main`.

```bash
git checkout -b users/Brandon/Step1
git add .
git commit -m "Step 1"
git push -u origin users/Brandon/Step1
```
