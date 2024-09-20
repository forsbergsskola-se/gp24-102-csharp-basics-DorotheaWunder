int inputNumber;
char charAssigned;
string outputAsciiSign;

Console.WriteLine("How many rows do you want for your pattern?");
inputNumber = Convert.ToInt32(Console.ReadLine());

//int modulo = inputNumber % 2;
//charAssigned = modulo != 0 ? "#" : "-";

for (int i = 0; i < inputNumber; i++ )
{
    for (int j = 0; j < inputNumber; j++ )
    {
        outputAsciiSign = new string('#', inputNumber);
        Console.WriteLine(outputAsciiSign);
    }
    outputAsciiSign = new string('-', inputNumber);
    Console.WriteLine(outputAsciiSign);
    Console.WriteLine("\n");
}



//nested loop; outer for #, inner for -
//inner and out loop both use same input nr
//where does goto enter??? (bottom of outer loop?
//will I need row and column?
//ist inputnr gerade? # Inputnr ungerqde -