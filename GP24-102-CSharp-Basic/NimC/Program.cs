char menuNavigation = ' ';
bool isGameRunning = true;
bool isPlayerGreenTurn = true;
bool bothPlacedShips = false;
int[] originalShipTypes = { 5, 4, 3, 2, 2};
int[] usedShipTypes;

string letterRange = "abcdefghij";

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
Gameflow();


void Gameflow()
{
    InitializeShipTypes();
    
    while (isGameRunning)
    {
        if (isPlayerGreenTurn)
        {
            PlaceShipsPhase(); 
        }
        else
        {
            PlaceShipsPhase();  
        }
    }
    if (bothPlacedShips) 
    {
        Console.WriteLine("GOES TO BATTLE PHASE");
        while (true) 
        {
            if (isPlayerGreenTurn)
            {
                ShootingPhase(); 
            }
            else
            {
                ShootingPhase();
            }
            Console.WriteLine("check for end conditions");
            // Check for end game conditions or breaks here
            // If one player has won, set gameRunning to false
        }
    }
}

void PlaceShipsPhase()
{
    if (bothPlacedShips)
    {
        Console.WriteLine("All ships have been placed. Now it’s time to shoot!");
        //shooting phase
        return; 
    }
    
    int shipSize = usedShipTypes.First();
    string[,] currentGrid = isPlayerGreenTurn ? gridGreen : gridPink;
    
    Console.WriteLine($"Player {(isPlayerGreenTurn ? "GREEN" : "PINK") } - place your ships on the grid");
    
    ChooseStartingCoordinate:
    Console.WriteLine($"Placing a ship of size -{usedShipTypes.First()}-.Enter the ship's starting coordinate");
    EnterCoordinatesInput();
    int row = inputNumber;
    int col = convertedLetter;

    //current grid used to have input and letters as arguments
    if (currentGrid[row, col] != "*")
    {
        AssignChar();
        Console.WriteLine("This will be the ship's starting coordinate");
    }
    else
    {
        Console.WriteLine("This coordinate is already taken. Pick an empty field.");
        goto ChooseStartingCoordinate;
    }
    
    ChooseShipOrientation:
    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Press Key V to place the ship VERTICALLY");
    Console.WriteLine("Press Key H to place the ship HORIZONTALLY");
    Console.WriteLine("Press Key B to return BACK to entering the starting coordinates");
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
        //also make sure X doesnt turn into blank
        if (currentGrid[inputNumber, convertedLetter] != "*")
        {
            currentGrid[inputNumber, convertedLetter] = " ";
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
    
    if (IsPlacementValid(row, col, shipSize, direction, currentGrid))
    {
        PlaceShip(row, col, shipSize, direction, currentGrid);
        Console.WriteLine($"Battleship length -{usedShipTypes.First()}- has been placed");
    }
    else
    {
        if (currentGrid[inputNumber, convertedLetter] != "*")
        {
            currentGrid[inputNumber, convertedLetter] = " ";
        }
        Console.WriteLine("Invalid placement! Try again.");
        goto ChooseStartingCoordinate;
    }
    usedShipTypes = usedShipTypes.Skip(1).ToArray();
    if (usedShipTypes.Any())
    {
        PlaceShipsPhase(); 
    }
    else
    {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("THIS IS THE CURRENT PLACEMENT OF YOUR ARMADA");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Press any key to end your turn");
            Console.ReadKey();
            //----------------------------
            HideSymbols(currentGrid);
            //----------------------------
            
            isPlayerGreenTurn = !isPlayerGreenTurn;
            if (!isPlayerGreenTurn)
            {
                
                RefillShipTypes();
                PlaceShipsPhase();
            }
            else
            {
                Console.WriteLine("transition to shooting phase");
                ShootingPhase(); 
            }
    }
    bothPlacedShips = !bothPlacedShips;
    //HideSymbols(currentGrid);
}

bool IsPlacementValid(int row, int col, int size, char direction, string[,] grid)
{
    if (direction == 'H' && col + size > grid.GetLength(1)) return false; 
    
    if (direction == 'V' && row + size > grid.GetLength(0)) return false;

    for (int i = 0; i < size; i++)
    {
        if (direction == 'H' && grid[row, (col + i) + 1] != " ") return false;
        if (direction == 'V' && grid[(row + i) + 1, col] != " ") return false;
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

void ShootingPhase()
{
    Console.WriteLine($"{(isPlayerGreenTurn ? "PINK" : "GREEN") }, it's your time to shoot!");
    EnterCoordinatesGuess();
    // Console.WriteLine("press key to check coordinates");
    // Console.ReadKey();
    CheckForHit();
    Console.WriteLine("press any key to end your turn");
    Console.ReadKey();
    //isPlayerGreenTurn = !isPlayerGreenTurn;
    ShootingPhase();
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
        PlaceShipsPhase();
    }
    Console.WriteLine();
    
    Console.WriteLine("NUMBER coordinate");
    inputNumber = Convert.ToInt32(Console.ReadLine());
    if (inputNumber == 0) { inputNumber = 10;}
    
    
    // if (isPlayerGreenTurn)
    // {
    //     AssignChar();
    // }
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
}

void HideSymbols(string[,] grid)
{
    for(int i = 0; i < grid.GetLength(0); i++)
    {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            if (grid[i,j] == "*")
            {
                grid[i, j] = " ";
            }
        }
    }
}

void EnterCoordinatesGuess()
{
    Console.WriteLine();
    DisplayGrid();
    Console.WriteLine($"{(isPlayerGreenTurn ? "PINK" : "GREEN") }, it's your turn to shoot!");
    Console.WriteLine($"Which coordinate of {(isPlayerGreenTurn ? "GREEN'" : "PINK'") }s field do you wan to attack?");
    Console.WriteLine("LETTER coordinate");
    guessedLetter = Console.ReadKey().KeyChar;
    guessedLetterConv = ConvertToNumber(guessedLetter);
    if (guessedLetterConv == -1)
    {
        Console.WriteLine("The letter you chose is out of range.");
        ShootingPhase();
    }
    Console.WriteLine();
    
    Console.WriteLine("NUMBER coordinate");
    guessedNumber = Convert.ToInt32(Console.ReadLine());
    if (guessedNumber == 0) { guessedNumber = 10;}
}

void CheckForHit()
{
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
        }
        else
        {
            Console.WriteLine("You missed!");
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

void InitializeShipTypes()
{
    usedShipTypes = (int[])originalShipTypes.Clone();
}

void RefillShipTypes()
{
    usedShipTypes = (int[])originalShipTypes.Clone();
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


