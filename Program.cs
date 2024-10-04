// See https://aka.ms/new-console-template for more information
LearningActivity31();
LearningActivity32();
LearningActivity33();
LearningActivity34();
LearningActivity35();

void LearningActivity31()
{
    Console.WriteLine("This is the function for Learning Activity 3.1!");
    
    // Function to convert temperature
    Console.WriteLine("Enter the temperature to convert:");
    double userTemperature = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Convert To Fahrenheit (f) or Celsius (C)?");

    string conversionScale = Console.ReadLine();
    double resultTemperature = TemperatureConverter(userTemperature, conversionScale);

    Console.WriteLine("Converted Temperature: " + resultTemperature);
}

double TemperatureConverter(double inputTemperature, string targetScale)
{
    double convertedTemperature = 0;

    switch (targetScale.ToLower())
    {
        case "f":
            // Celsius to Fahrenheit
            convertedTemperature = (inputTemperature * 9 / 5) + 32;
            break;

        case "c":
            // Fahrenheit to Celsius
            convertedTemperature = (inputTemperature - 32) * 5 / 9;
            break;
    }

    return convertedTemperature;
}

void LearningActivity32()
{
    Console.WriteLine("This is the function for Learning Activity 3.2!");
    // 1) Array of classmate names
    string[] classmateNames = new string[] { "Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Hank", "Isabella", "Jack", "Karen", "Liam", "Mia", "Noah" };

    // 2) Array of classmate ages
    int[] classmateAges = new int[] { 20, 21, 19, 22, 23, 20, 21, 24, 22, 19, 23, 20, 22, 21 };

    // 3) Array of the 7 wonders of the world
    string[] wondersOfTheWorld = new string[] { "Great Wall of China", "Petra", "Christ the Redeemer", "Machu Picchu", "Chichen Itza", "Roman Colosseum", "TajMahal" };

    // Print out the data
    Console.WriteLine("Classmates and their ages:");

    for (int i = 0; i < classmateNames.Length; i++)
    {
        Console.WriteLine(classmateNames[i] + " is " + classmateAges[i] + " years old.");
    }

    Console.WriteLine("\n7 Wonders of the World:");
    foreach (var wonder in wondersOfTheWorld)
    {
        Console.WriteLine(wonder);
    }
}

void LearningActivity33()
{
    // 3x3 Tic-Tac-Toe board
    int[,] ticTacToeBoard = new int[3, 3]
    {   { 1, 2, 0 },
        { 2, 1, 0 },
        { 2, 1, 1 }
    };

    PrintBoard(ticTacToeBoard);
    int winner = CheckWinner(ticTacToeBoard);
    switch (winner)
    {
        case 1:
            Console.WriteLine("X (1) has won the game!");
            break;
        case 2:
            Console.WriteLine("O (2) has won the game!");
            break;
        case 0:
            Console.WriteLine("It's a tie or the game is still ongoing.");
            break;
    }
}
int CheckWinner(int[,] board)
{
    // Check rows
    for (int i = 0; i < 3; i++)
    {
        if (board[i, 0] == board[i, 1] && board[i, 1] == board[i,2] && board[i, 0] != 0)
        {
            return board[i, 0]; // Return the winner (1 or 2)
        }
    }
    // Check columns
    for (int i = 0; i < 3; i++)
    {
        if (board[0, i] == board[1, i] && board[1, i] == board[2,i] && board[0, i] != 0)
        {
            return board[0, i]; // Return the winner (1 or 2)
        }
    }
    // Check diagonals
    if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2]&& board[0, 0] != 0)
    {
        return board[0, 0]; // Return the winner (1 or 2)
    }
    if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]
&& board[0, 2] != 0)
    {
        return board[0, 2]; // Return the winner (1 or 2)
    }
    // No winner, return 0 for a tie or ongoing game
        return 0;
}
static void PrintBoard(int[,] board)
{
    Console.WriteLine("Tic-Tac-Toe Board:");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(board[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void LearningActivity34()
{
    int number;
    bool success = int.TryParse(Console.ReadLine(), out number); //example code
    Console.WriteLine("This is the function for Learning Activity 3.4!");

    int userAge;

    bool isValid = false;

    // Loop until valid input is entered

    while (!isValid)

    {

        Console.WriteLine("Please enter your age (between 10 and 50):");

        string input = Console.ReadLine();

        // Try to parse the input as an integer

        bool bsuccess = int.TryParse(input, out userAge);

        if (bsuccess && userAge >= 10 && userAge <= 50)

        {
            // Valid age

            isValid = true;

            Console.WriteLine("Thank you! Your age is: " + userAge);
        }
        else

        {

            // Invalid input, continue asking

            Console.WriteLine("Invalid age. Please enter a whole number between 10 and 50.");
        }
    }
}

void LearningActivity35()
{
    int number;
    int[] highScores = { 1272700, 1271100, 1243000, 1218000, 1214300, 1210800, 1210400, 1206800, 1178400 };
    Console.WriteLine("This is the function for Learning Activity 3.5!"); 
    // Creates a list of Dice, which will be the basis of the dice in the program
    List<Dice> rolledDice = new List<Dice>();
    string playerInput = "";
    //create a list of dice pool
    while (true)
    {
        Console.WriteLine("Would you like to Add or Remove a dice to the pool, or would you like to Roll the dice in the pool? enter quit to leave.");
        playerInput = Console.ReadLine().ToLower();
        if (playerInput == "add")
        {
            Console.WriteLine("How man sides are there to this dice? (must be >4 and an even number)");
            if (int.TryParse(Console.ReadLine(), out int diceAnswer) && diceAnswer >= 4 && diceAnswer % 2 == 0)
            {
                Dice newDie = new Dice(diceAnswer);
                rolledDice.Add(newDie);
                Console.WriteLine($"Added a {diceAnswer} sided dice to the dice pool, there are currently {rolledDice.Count} dice in the pool.");
            }
            else
            {
                Console.WriteLine("Please enter a valid number of sides for the dice.");
            }
        }
        else if (playerInput == "remove")
        {
            Console.WriteLine("Enter the number of sides for the dice that's being removed");
            if (int.TryParse(Console.ReadLine(), out int dieRemoval) && dieRemoval >= 4 && dieRemoval % 2 == 0)
            {
                Dice dieToBeRemoved = rolledDice.Find(die => die.sides == dieRemoval);
                if (dieToBeRemoved != null)
                {
                    rolledDice.Remove(dieToBeRemoved);
                    Console.WriteLine($"Removed the {dieRemoval} sided die as requested.");
                }
                else
                {
                    Console.WriteLine($"There is no {dieRemoval} sided dice in this pool of Dice");
                }
            }
            else
            {
                Console.WriteLine("Please Enter a valid number of dice sides.");
            }
        }
        else if (playerInput == "roll")
        {
            if (rolledDice.Count == 0)
            {
                Console.WriteLine("The dice pool is currently empty, consider adding some dice to roll.");
            }
            else
            {
                int total = DicePool.RollTheDice(rolledDice);
                Console.WriteLine($"You rolled a total of {rolledDice.Count} dice");
            }
        }
        else if (playerInput.ToLower() == "quit")
        {
            break;
        }
        else
        {
            Console.WriteLine("Please enter a valid option.");
        }
    }
    Console.Read();
}

class Dice
{
    // Set the side variable to be a getter
    public int sides { get; }
    Random randRoll = new Random();

    // Set the amount of side to the dice when instaniating a single Die
    public Dice(int diceSides)
    {
        sides = diceSides;
    }

    // Rolls the dice and adds 1 to the dice size so that the range is inclusive of the dice sides.
    public int RollEm()
    {
        return randRoll.Next(1, sides + 1);
    }
}

class DicePool
{
    // Rolls all of the dice in the class which is just a pool of collected dice
    public static int RollTheDice(List<Dice> dicePool)
    {
        int total = 0;
        foreach (Dice die in dicePool)
        {
            int rollResult = die.RollEm();
            Console.WriteLine($"You rolled a {rollResult} on a {die.sides} sided dice.");
            total += rollResult;
        }

        return total;
    }
}