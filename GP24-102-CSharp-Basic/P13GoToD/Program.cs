int inputNumber;
string outputAsciiSign;

Console.WriteLine("How many rows do you want for your pattern?");
inputNumber = Convert.ToInt32(Console.ReadLine());

// int modulo = inputNumber % 2;
// outputAsciiSign = modulo != 0 ? "#" : "-";

for (int i = 0; i < inputNumber; i++ )
{
    for (int j = 0; j < inputNumber; j++ )
    {
        if (j % 2 != 0)
        {
            Console.Write("#");
            Console.Write("-");
        }
        else
        {
            Console.Write("#");
            Console.Write("-");
        }
    }
    Console.WriteLine();
}



//Console.WriteLine("\n");
