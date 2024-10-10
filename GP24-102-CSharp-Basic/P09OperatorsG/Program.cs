int numberInput;
int numberNegative;

Console.WriteLine("Write a number");
numberInput = Convert.ToInt32(Console.ReadLine());

numberNegative = -numberInput;

Console.WriteLine($"The negative of {numberInput} is {numberNegative}");