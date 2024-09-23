int inputColumn = 0;
int inputRow = 0;
bool isPlayerTurn = true;
string[,] grid = 
  {
    { " ", " ", " " },
    { " ", " ", " " },
    { " ", " ", " " }
  };

Console.WriteLine("Welcome to Tic-Tac-Toe");
DisplayGrid();
TurnPlayer();

void TurnPlayer()
{
    SelectColumn:
    Console.WriteLine("In which COLUMN from 1-3 do you want to place your x?");
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
    Console.WriteLine("In which ROW from 1-3 do you want to place your x?");
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
    if(string.IsNullOrWhiteSpace(grid[inputColumn, inputRow]))
    {
        AssignChar();
        TurnPlayer();
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
        grid.SetValue("x",inputColumn -1,inputRow -1);
    }
    else
    {
        grid.SetValue("o",inputColumn -1,inputRow -1);
    }
    DisplayGrid();
    //switch player bool?
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
      //alternating colors dependint if isPlayer is true or not
      
      
      // Console.ForegroundColor = Console.BackgroundColor == ConsoleColor.Yellow
      //  ? ConsoleColor.DarkBlue
      //  : ConsoleColor.DarkRed;

      Console.Write(" " + grid[i,j] + " ");
      Console.ResetColor();
    }
    Console.WriteLine();
   }
 }