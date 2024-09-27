int inputSeconds;
float calculatedMinutes;
float calculatedSeconds;

Console.WriteLine("Type the number of your seconds: ");
inputSeconds = Convert.ToInt32(Console.ReadLine());

calculatedMinutes = (float)inputSeconds / 60;
calculatedSeconds = calculatedMinutes % 1;
calculatedMinutes = (int)calculatedMinutes;
calculatedSeconds = (int)(calculatedSeconds * 100);

Console.WriteLine($"{inputSeconds} seconds is {calculatedMinutes} minute(s) and {calculatedSeconds} second(s) in total.");