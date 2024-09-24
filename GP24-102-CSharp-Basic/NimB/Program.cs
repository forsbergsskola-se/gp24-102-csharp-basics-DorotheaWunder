using System.Text;
Console.OutputEncoding = Encoding.UTF8;

bool isPlayerTurn = true;
bool hasWon = false;
string winMessage = @"
     .-.
    (o o) boo!
    | O \
     \   \
      `~~~'";

int inputColumn = 0;
int inputRow = 0;
string[,] grid = 
  {
    { " ", " ", " " },
    { " ", " ", " " },
    { " ", " ", " " }
  };


StartMenu();


void StartMenu()
{
    Console.WriteLine("----- Welcome to Tic-Tac-Toe -----");
    Console.WriteLine();
    
    TurnPlayer();
}

void TurnPlayer()
{
    Console.WriteLine();
    DisplayGrid();
    
    SelectColumn:
    Console.WriteLine($"{(isPlayerTurn ? "PLAYER 1" : "PLAYER 2") }, it's your turn!");
    Console.WriteLine("In which COLUMN from 1-3 do you want to place your sign?");
    inputColumn = Convert.ToInt32(Console.ReadLine());
    if (inputColumn >0 && inputColumn <=3)
    {
        //goto SelectRow;
    }
    else
    {
        Console.WriteLine("This is not a valid number. You can only pick from 1 - 3!");
        goto SelectColumn;
    }
    
    SelectRow:
    Console.WriteLine($"{(isPlayerTurn ? "PLAYER 1" : "PLAYER 2") }, it's your turn!");
    Console.WriteLine("In which ROW from 1-3 do you want to place your sign?");
    inputRow = Convert.ToInt32(Console.ReadLine());
    if (inputRow >0 && inputRow <=3)
    {
        CheckCoordinates();
    }
    else
    {
        Console.WriteLine("This is not a valid number. You can only pick from 1 - 3!");
        goto SelectRow;
    }
}

void CheckCoordinates()
{
    if(string.IsNullOrWhiteSpace(grid[inputRow -1, inputColumn -1]))
    {
        AssignChar();
    }
    else
    {
        Console.WriteLine("This position is already taken!");
        TurnPlayer();
    }
}

void AssignChar()
{
    if (isPlayerTurn)
    {
        grid.SetValue("x",inputRow -1, inputColumn -1);
    }
    else
    {
        grid.SetValue("o",inputRow -1, inputColumn -1);
    }
    DisplayGrid();
    isPlayerTurn = !isPlayerTurn;
    CheckGameEnd();
}

void CheckGameEnd()
{
    for (int column = 0; column < 3; column++)
    {
        if (grid[0, column] == "x" && grid[1, column] == "x" && grid[2, column] == "x")
        {
            hasWon = true;
        }
    }
    for (int row = 0; row < 3; row++)
    {
        if (grid[row, 0] == "x" && grid[row, 1] == "x" && grid[row, 2] == "x")
        {
            hasWon = true;
        }
    }

    if ((grid[0, 0] == "x" && grid[1, 1] == "x" && grid[2, 2] == "x") ||
        (grid[0, 2] == "x" && grid[1, 1] == "x" && grid[2, 0] == "x"))
    {
        hasWon = true;
    }
    GameEndResult();
}

void GameEndResult()
{
    if (hasWon)
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("----- THE GAME HAS ENDED -----");

        if (hasWon)
        {
            Console.WriteLine("----- PLAYER 1 WON -----");
            
        }
        else
        {
            Console.WriteLine("----- PLAYER 2 WON -----");
        }
        Console.WriteLine(winMessage);
    }
    else
    {
        TurnPlayer();
    }
    
}

ConsoleColor AssignColorSquares(int row, int column)
 {
  return (row + column) % 2 == 0 ? ConsoleColor.Yellow : ConsoleColor.DarkYellow;
 }

void DisplayGrid()
 {
   for(int i = 0; i < grid.GetLength(0); i++)
   {
    for (int j = 0; j < grid.GetLength(1); j++)
    {
      Console.BackgroundColor = AssignColorSquares(i, j);
      Console.ForegroundColor = ConsoleColor.Black;

      Console.Write(" " + grid[i,j] + " ");
      Console.ResetColor();
    }
    Console.WriteLine();
   }
 }
 
