int minutes;
int seconds;

Console.WriteLine("How many minutes do you have?");
minutes = Convert.ToInt32(Console.ReadLine());

seconds = minutes * 60;

Console.WriteLine($"{minutes} minutes? That's {seconds} seconds.");