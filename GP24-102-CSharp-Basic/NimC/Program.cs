bool isPlayerGreen = true;

string[] shipTypes =
{
    "2 SQUARES",
    "2 SQUARES",
    "3 SQUARES",
    "4 SQUARES",
    "5 SQUARES",
};

string letterRange = "abcdefhij";

string[,] gridGreen = 
{
    { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", " "},
    { "1", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "1"},
    { "2", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "2"},
    { "3", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "3"},
    { "4", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "4"},
    { "5", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "5"},
    { "6", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "6"},
    { "7", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "7"},
    { "8", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "8"},
    { "9", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "9"},
    { "0", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "0"},
    { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", " "},
};
string[,] gridPink = 
{
    { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", " "},
    { "1", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "1"},
    { "2", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "2"},
    { "3", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "3"},
    { "4", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "4"},
    { "5", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "5"},
    { "6", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "6"},
    { "7", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "7"},
    { "8", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "8"},
    { "9", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "9"},
    { "0", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "0"},
    { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", " "},
};
char inputLetter = ' ';
int convertedLetter = 0;
int inputNumber = 0;

Console.WriteLine("--------WELCOME TO BATTLESHIPS--------");
Console.WriteLine();
TurnPlayer();


void TurnPlayer()
{
    Console.Clear();
    DisplayGrid();
    Console.WriteLine($"{(isPlayerGreen ? "GREEN" : "PINK") }, it's your turn to shoot!");
    Console.WriteLine($"Which coordinate of {(isPlayerGreen ? "PINK'" : "GREEN'") }s field do you wan to attack?");
    Console.WriteLine("LETTER coordinate");
    inputLetter = Console.ReadKey().KeyChar;
    LettersToNumbers();
    Console.WriteLine();
    
    Console.WriteLine("NUMBER coordinate");
    inputNumber = Convert.ToInt32(Console.ReadLine());
    
    if (isPlayerGreen)
    {
        gridPink[convertedLetter, inputNumber] = "X";
    }
    else
    {
        gridGreen[convertedLetter, inputNumber] = "X";
    }
    Console.WriteLine("-------------------------------------");
    DisplayGrid();
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Press any key to continue");
    Console.ReadKey();
    isPlayerGreen = !isPlayerGreen;
    TurnPlayer();
}

void CheckHit()
{
    //is not empty? then its hit
    //is hit? change color of sqaure
}
void LettersToNumbers()
{
    if (char.IsUpper(inputLetter))
    {
        inputLetter = char.ToLower(inputLetter);
    }
    
    if (letterRange.IndexOf(inputLetter) != -1)
    {
         convertedLetter = letterRange.IndexOf(inputLetter) + 1; 
    }
    else
    {
        Console.WriteLine("The letter you chose is out of range.");
        TurnPlayer();
    }

}

ConsoleColor AssignColorSquares(int row, int column)
{
    if (isPlayerGreen)
    {
            return (row + column) % 2 == 0 ? ConsoleColor.Magenta : ConsoleColor.DarkMagenta;
    }
    else
    {
        return (row + column) % 2 == 0 ? ConsoleColor.Green : ConsoleColor.DarkGreen;
    }
}

void DisplayGrid()
{
    if (isPlayerGreen)
    {
        for(int i = 0; i < gridPink.GetLength(0); i++)
        {
            for (int j = 0; j < gridPink.GetLength(1); j++)
            {
                Console.BackgroundColor = AssignColorSquares(i, j);
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Write(" " + gridPink[i,j] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
    else
    {
        for(int i = 0; i < gridGreen.GetLength(0); i++)
        {
            for (int j = 0; j < gridGreen.GetLength(1); j++)
            {
                Console.BackgroundColor = AssignColorSquares(i, j);
                Console.ForegroundColor = ConsoleColor.Black;

                Console.Write(" " + gridGreen[i,j] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
}


