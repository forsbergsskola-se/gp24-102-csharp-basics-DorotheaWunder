int inputSeconds;
int calculatedSeconds;
int calculatedMinutes;
int calculatedHours;
int calculatedDays;
float calculatedDaysFloat;

Console.WriteLine("Give me a number of seconds");
inputSeconds = Convert.ToInt32(Console.ReadLine());

calculatedDaysFloat = (float)inputSeconds / 86400;
calculatedSeconds = inputSeconds / 60;
calculatedMinutes = calculatedSeconds / 60;
calculatedHours = calculatedMinutes / 24;
calculatedDays = calculatedHours / 365;

calculatedDays = calculatedHours % 365;
calculatedHours = calculatedMinutes % 24;
calculatedMinutes = calculatedSeconds % 60;
calculatedSeconds = inputSeconds % 60;

Console.WriteLine($"{calculatedSeconds} seconds");
Console.WriteLine($"{calculatedMinutes} minutes");
Console.WriteLine($"{calculatedHours} hours");
Console.WriteLine($"{calculatedDays} days");

Console.WriteLine($"{calculatedDays} - {calculatedHours} - {calculatedMinutes} - {calculatedSeconds}");
Console.WriteLine($"In total, that's {calculatedDaysFloat} days");