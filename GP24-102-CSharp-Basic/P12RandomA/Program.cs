int inputSeed;
double critChance;
string critResult;

Console.WriteLine("Enter an integer for the seed");
inputSeed = Convert.ToInt32(Console.ReadLine());
Random random = new Random(inputSeed);

int randomIntA = random.Next(0, 5);
int randomIntB = random.Next(0, 5);
int randomIntC = random.Next(0, 5);

Console.WriteLine($"Your seed of {inputSeed} has generated the following three int numbers betw. 0 - 5:");
Console.WriteLine(randomIntA);
Console.WriteLine(randomIntB);
Console.WriteLine(randomIntC);

Console.WriteLine($"Your seed of {inputSeed} has generated the following three decimal numbers betw. 0.0 - 0.5:");
double randomDoubleA = random.NextDouble()* 0.5;
double randomDoubleB = random.NextDouble()* 0.5;
double randomDoubleC = random.NextDouble()* 0.5;

Console.WriteLine(randomDoubleA);
Console.WriteLine(randomDoubleB);
Console.WriteLine(randomDoubleC);

Console.WriteLine($"Your seed of {inputSeed} has generated the following three decimal numbers betw. 0.2 - 0.7:");
randomDoubleA = random.NextDouble()* (0.7-0.2)+0.2;
randomDoubleB = random.NextDouble()* (0.7-0.2)+0.2;
randomDoubleC = random.NextDouble()* (0.7-0.2)+0.2;

Console.WriteLine(randomDoubleA);
Console.WriteLine(randomDoubleB);
Console.WriteLine(randomDoubleC);

Console.WriteLine("Now give me a crit chance between 0% and 100% (0.0 - 1.0)");
critChance = double.Parse(Console.ReadLine());


for (int i = 0; i < 5; i++ )
{
    if (random.NextDouble() < critChance)
    {
        critResult = "You made a critical hit!";
        Console.WriteLine(critResult);
    }
    else
    {
        critResult = "No crit for you :P";
        Console.WriteLine(critResult);
    }
}

