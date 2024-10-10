int inputNumberRows;
string outputAsciiSign;

Console.WriteLine("How many rows is your triangle suppose to have?");
inputNumberRows = Convert.ToInt32(Console.ReadLine());

PrintAscii:
outputAsciiSign = new string('#', inputNumberRows);
Console.WriteLine(outputAsciiSign);

if (inputNumberRows != 0)
{
    inputNumberRows = inputNumberRows - 1;
    goto PrintAscii;
}