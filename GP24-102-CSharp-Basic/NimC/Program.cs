char menuNavigation = ' ';
bool isPlayerGreenTurn = true;
int[] shipTypes = { 5, 4, 3, 2, 2};

string letterRange = "abcdefghij";

//have extra grid string just for color coding??
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
//to mark the coordinate
char inputLetter = ' ';
int convertedLetter = 0;
int inputNumber = 0;

//to COMPARE the coordinate
char guessedLetter = ' ';
int guessedLetterConv = 0;
int guessedNumber = 0;



Console.WriteLine("--------WELCOME TO BATTLESHIPS--------");
PlaceShipsPhase();

//TurnPlayer();

void PlaceShipsPhase()
{
    Console.WriteLine($"Player {(isPlayerGreenTurn ? "GREEN" : "PINK") } - place your ships on the grid");
    
    ChooseStartingCoordinate:
    Console.WriteLine($"Placing a ship of size --{shipTypes.First()}--.Enter the ship's starting coordinate");
    EnterCoordinatesInput();
    int row = inputNumber;
    int col = convertedLetter;
    Console.WriteLine($"This will be the ship's starting coordinate");
    
    ChooseShipOrientation:
    Console.WriteLine("-------------------------------------");
    Console.WriteLine($"Press Key V to place the ship VERTICALLY");
    Console.WriteLine($"Press Key H to place the ship HORIZONTALLY");
    Console.WriteLine($"Press Key B to return BACK to entering the starting coordinates");
    menuNavigation = Console.ReadKey().KeyChar;
    
    char direction = ' ';
    
    if (menuNavigation.Equals('V')|| menuNavigation.Equals('v'))
    {
        Console.WriteLine("-------------------------------------");
        direction = 'V';
    }
    else if (menuNavigation.Equals('H')|| menuNavigation.Equals('h'))
    {
        Console.WriteLine("-------------------------------------");
        direction = 'H';
    }
    else if (menuNavigation.Equals('B') || menuNavigation.Equals('b'))
    {
        if (isPlayerGreenTurn)
        {
            gridGreen[inputNumber, convertedLetter] = " ";
        }
        else
        {
            gridPink[inputNumber, convertedLetter] = " ";
        }
        DisplayGrid();
        goto ChooseStartingCoordinate;
    }
    else
    {
        Console.WriteLine("You didn't enter a valid key");
        DisplayGrid();
        goto ChooseShipOrientation;
    }
    int shipSize = shipTypes.First();
    string[,] currentGrid = isPlayerGreenTurn ? gridGreen : gridPink;
    
    if (IsPlacementValid(row, col, shipSize, direction, currentGrid))
    {
        PlaceShip(row, col, shipSize, direction, currentGrid);
        Console.WriteLine($"Battleship length --{shipTypes.First()}-- has been placed");
    }
    else
    {
        if (isPlayerGreenTurn)
        {
            gridGreen[inputNumber, convertedLetter] = " ";
        }
        else
        {
            gridPink[inputNumber, convertedLetter] = " ";
        }
        Console.WriteLine("Invalid placement! Try again.");
        goto ChooseStartingCoordinate;
    }
}

bool IsPlacementValid(int row, int col, int size, char direction, string[,] grid)
{
    if (direction == 'H' && col + size > grid.GetLength(1)) return false; 
    
    if (direction == 'V' && row + size > grid.GetLength(0)) return false;

    for (int i = 0; i < size; i++)
    {
        if (direction == 'H' && grid[row, col + i] != " ") return false;
        if (direction == 'V' && grid[row + 1, col] != " ") return false;
    }
    return true;
}

void PlaceShip(int row, int col, int size, char direction, string[,] grid)
{
    for (int i = 0; i < size; i++)
    {
        if (direction == 'H')
        {
            grid[row, col + i] = "*";  
        }
        else if (direction == 'V')
        {
            grid[row + i, col] = "*";  
        }
    }
    DisplayGrid();
    //should have grid as argument
}


void TurnPlayer()
{
    EnterCoordinatesInput();
    EnterCoordinatesGuess();
    Console.WriteLine("press key to check coordinates");
    Console.ReadKey();
    CheckForHit();
    Console.WriteLine("press key to end your turn");
    Console.ReadKey();
    isPlayerGreenTurn = !isPlayerGreenTurn;
    TurnPlayer();
}

void EnterCoordinatesInput()
{
    Console.WriteLine();
    DisplayGrid();
    Console.WriteLine($"{(isPlayerGreenTurn ? "GREEN" : "PINK") }, where do you want to place your marker?");
    Console.WriteLine("LETTER coordinate");
    inputLetter = Console.ReadKey().KeyChar;
    convertedLetter = ConvertToNumber(inputLetter);
    if (convertedLetter == -1)
    {
        Console.WriteLine("The letter you chose is out of range.");
        TurnPlayer();
    }
    Console.WriteLine();
    
    Console.WriteLine("NUMBER coordinate");
    inputNumber = Convert.ToInt32(Console.ReadLine());

    if (isPlayerGreenTurn)
    {
        AssignChar();
    }
}

void AssignChar()
{
    if (isPlayerGreenTurn)
    {
        gridGreen[inputNumber, convertedLetter] = "x";
    }
    else
    {
        gridPink[inputNumber, convertedLetter] = "x";
    }
    Console.WriteLine("-------------------------------------");
    DisplayGrid();
    Console.WriteLine("---------- updated field ----------");
    ///---------------------- maybe end turn not needed yet
    // Console.WriteLine("   Press any key to end your turn   ");
    // Console.ReadKey();
}

void EnterCoordinatesGuess()
{
    Console.WriteLine();
    //players markers need to be hidden -- HOW??
    DisplayGrid();
    Console.WriteLine($"{(isPlayerGreenTurn ? "PINK" : "GREEN") }, it's your turn to shoot!");
    Console.WriteLine($"Which coordinate of {(isPlayerGreenTurn ? "GREEN'" : "PINK'") }s field do you wan to attack?");
    Console.WriteLine("LETTER coordinate");
    guessedLetter = Console.ReadKey().KeyChar;
    guessedLetterConv = ConvertToNumber(guessedLetter);
    if (guessedLetterConv == -1)
    {
        Console.WriteLine("The letter you chose is out of range.");
        TurnPlayer();
    }
    Console.WriteLine();
    
    Console.WriteLine("NUMBER coordinate");
    guessedNumber = Convert.ToInt32(Console.ReadLine());
}

void CheckForHit()
{
    //make players marker invisible
    if (isPlayerGreenTurn)
    {
        if (gridGreen[inputNumber, convertedLetter] == gridGreen[guessedNumber, guessedLetterConv])
        {
            Console.WriteLine("YOU HIT!!");
            gridGreen[guessedNumber, guessedLetterConv] = "#";
            DisplayGrid();
        }
        else
        {
            Console.WriteLine("You missed!");
            gridGreen[guessedNumber, guessedLetterConv] = "-";
            DisplayGrid();
        }
    }
    else
    {
        if (gridPink[inputNumber, convertedLetter] == gridPink[guessedNumber, guessedLetterConv])
        {
            Console.WriteLine("YOU HIT!!");
            //turn foreground in string of this array black?
        }
        else
        {
            Console.WriteLine("You missed!");
            //turn foreground in string of this array black?
        }
    }
}

int ConvertToNumber(char inputLetter)
{
    if (char.IsUpper(inputLetter))
    {
        inputLetter = char.ToLower(inputLetter);
    }
    
    if (letterRange.IndexOf(inputLetter) != -1)
    {
        return letterRange.IndexOf(inputLetter) + 1; 
    }
    return -1;
}

ConsoleColor AssignColorSquares(int row, int column)
{
    if (isPlayerGreenTurn)
    {
            return (row + column) % 2 == 0 ? ConsoleColor.Green : ConsoleColor.DarkGreen;
    }
    else
    {
        return (row + column) % 2 == 0 ? ConsoleColor.Magenta : ConsoleColor.DarkMagenta;
    }
}

void DisplayGrid()
{
    if (isPlayerGreenTurn)
    {
        for(int i = 0; i < gridGreen.GetLength(0); i++)
        {
            for (int j = 0; j < gridGreen.GetLength(1); j++)
            {
                Console.BackgroundColor = AssignColorSquares(i, j);
                Console.ForegroundColor = ConsoleColor.Black;

                //check values on green grid; if its not blank ->make it blank
                Console.Write(" " + gridGreen[i,j] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }
    else
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
}


