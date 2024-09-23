int row;
int column;
string[,] grid = new string[3, 3]
  {
    { " ", " ", " " },
    { " ", " ", " " },
    { " ", " ", " " }
  };


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
      Console.ForegroundColor = Console.BackgroundColor == ConsoleColor.Yellow
       ? ConsoleColor.DarkYellow
       : ConsoleColor.Yellow;

      Console.Write(" " + grid[i,j] + " ");
      Console.ResetColor();
    }
    Console.WriteLine();
   }
 }
 
DisplayGrid();