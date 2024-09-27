Random random = new Random();
string message;
double chance = 0.1;
double randomRoll;

randomRoll = Random.Shared.NextDouble();

if (randomRoll < chance)
{
 message = "Wer das liest is doof.";
}
else
{
 message = "Try again.";
}

Console.WriteLine(message);