Random random = new Random();
int randomNumber = random.Next(1,101);;
int chosenNumber;

Console.WriteLine("I have picked a number between 1-100. Try if you can guess it.");

Console.WriteLine($"Psst, the number is {randomNumber}");
PlayerGuessNumber:
Console.WriteLine("Go ahead, guess my number.");
chosenNumber = Convert.ToInt32(Console.ReadLine());

if (chosenNumber == randomNumber)
{
    Console.WriteLine($"{chosenNumber}? Yes, you got it! Well done!");
}
else if(chosenNumber > randomNumber)
{
    Console.WriteLine($"{chosenNumber}? No, my number is smaller. Try again!");
    goto PlayerGuessNumber;
}
else if(chosenNumber < randomNumber)
{
    Console.WriteLine($"{chosenNumber}? No, my number is larger. Try again!");
    goto PlayerGuessNumber;
}
else
{
    return;
}