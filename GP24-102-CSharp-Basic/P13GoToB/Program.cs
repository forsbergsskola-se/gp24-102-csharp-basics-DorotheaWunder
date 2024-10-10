int inputDollarNumber;
string outputDollarNumber;

Console.WriteLine("Welcome to Scrooge McDuck Bank. How many Dollars would you like to retract?");
inputDollarNumber = Convert.ToInt32(Console.ReadLine());

outputDollarNumber = new string('$', inputDollarNumber);
Console.WriteLine($"Here's your money: {outputDollarNumber}");