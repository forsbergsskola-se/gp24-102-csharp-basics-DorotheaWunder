int numberOne;
int numberTwo;
int numberThree;

Console.WriteLine("Enter a number");
numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter another number");
numberTwo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Now enter your last number");
numberThree = Convert.ToInt32(Console.ReadLine());


int highestNumber = 0;
int lowestNumber = 0;

if (numberOne > numberTwo && numberOne > numberThree)
{
    highestNumber = numberOne;
}
else if (numberOne <= numberTwo && numberOne <= numberThree)
{
    lowestNumber = numberOne;
}

if (numberTwo >= numberOne && numberTwo >= numberThree)
{
    highestNumber = numberTwo;
}
else if (numberTwo <= numberOne && numberTwo <= numberThree)
{
    lowestNumber = numberTwo;
}

if (numberThree >= numberOne && numberThree >= numberTwo)
{
    highestNumber = numberThree;
}
else if (numberThree <= numberOne && numberThree <= numberTwo)
{
    lowestNumber = numberThree;
}

Console.WriteLine("Your lowest number is " + lowestNumber);
Console.WriteLine("Your highest number is " + highestNumber);
