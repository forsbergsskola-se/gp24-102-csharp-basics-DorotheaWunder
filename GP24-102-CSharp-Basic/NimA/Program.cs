int totalNumber = 24;
int inputNumber;
string shownMatches;
Random random = new Random();
int drawAI = random.Next(1, 4);


Console.WriteLine("Welcome to NIM");
Console.WriteLine("You can draw between 1 and 3 matches.");
DisplayMatches();

while (totalNumber > 0)
{
    PlayerTurn();
    AIturn();
}
GameResult();

void DisplayMatches()
{
    shownMatches = new string('|', totalNumber);
    Console.WriteLine(shownMatches + $" ({totalNumber})");
}

void PlayerTurn()
{
    Console.WriteLine();
    Console.WriteLine("How many matches do you want to draw?");
    inputNumber = Convert.ToInt32(Console.ReadLine());
    
    if (inputNumber >0 && inputNumber <=3)
    {
        totalNumber = totalNumber - inputNumber;
        DisplayMatches();
    }
    else
    {
        Console.WriteLine("This is not a valid number for the game. Try again.");
        DisplayMatches();
    }
}

void AIturn()
{
    Console.WriteLine();
    Console.WriteLine("Now it is the AI's turn to draw");
    Console.WriteLine($"The AI drew {drawAI} match(es)");
    totalNumber = totalNumber - drawAI;
    DisplayMatches();
}
    
void GameResult()
{
    Console.WriteLine();
    Console.WriteLine("The game is over.");
    if (totalNumber % 2 == 0)
    {
        Console.WriteLine("You won.");
    }
    else
    {
        Console.WriteLine("The AI won.");
    }
}
    
    



//for loop in turns as well?
//while loop instead of for?
//check modulo of total matches to determine who did the last turn?
///have a 2 player mode??